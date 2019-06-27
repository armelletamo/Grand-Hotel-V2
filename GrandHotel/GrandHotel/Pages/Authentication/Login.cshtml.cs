using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using GrandHotel.Pages.Reservations;
using GrandHotel.Data.Repository.Interface;

namespace GrandHotel.Pages.Authentication
{
    public class LoginModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IClient _client;
        private readonly ILogin _log;


        [BindProperty]
        public LoginViewModel Login { get; set; }
        public LoginModel(UserManager<IdentityUser> userManager, IConfiguration configuration, IClient client, ILogin log)
        {
            _userManager = userManager;
            _configuration = configuration;
            _client = client;
            _log = log;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [HttpPost]
        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(Login.Username);
                if (user != null && await _userManager.CheckPasswordAsync(user, Login.Password))
                {
                    string newtoken = TokenCreation(user.UserName);
                    if (_log.CheckToken(newtoken))
                    {
                        return Page();
                    }
                    HttpContext.Session.SetString("token", newtoken);
                    return Redirect(user.UserName);
                }
            }
                      
            return Page();
        }

        public new ActionResult Redirect(string username)
        {
            string path = "";
            
            try
            {
                path = (string)HttpContext.Session.GetString("redirectionpath");               
            }
            catch
            {
                return RedirectToPage("../Reservations/CreateReservation");
            }
            if (path != null && path.Contains("Reservations"))
            {              
                return RedirectToPage("../Clients/Bills", new { email = username } );
            }
            return RedirectToPage("../Reservations/CreateReservation");
        }

        public string TokenCreation(string username)
        {
            string newtoken = "";
            var claim = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, username)
                };
            var signinKey = new SymmetricSecurityKey(
              Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));

            int expiryInMinutes = Convert.ToInt32(_configuration["Jwt:ExpiryInMinutes"]);

            var token = new JwtSecurityToken(
              issuer: _configuration["Jwt:Site"],
              audience: _configuration["Jwt:Site"],
              claims: claim,
              notBefore: DateTime.Now,
              expires: DateTime.Now.AddMinutes(expiryInMinutes * 3),
              signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
            );

             newtoken = new JwtSecurityTokenHandler().WriteToken(token);
            return newtoken;
        }
    }
}