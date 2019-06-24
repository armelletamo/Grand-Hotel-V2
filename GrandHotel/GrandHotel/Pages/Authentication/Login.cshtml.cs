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
       

        [BindProperty]
        public LoginViewModel Login { get; set; }
        public LoginModel(UserManager<IdentityUser> userManager, IConfiguration configuration, IClient client)
        {
            _userManager = userManager;
            _configuration = configuration;
            _client = client;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [HttpPost]
        public async Task<ActionResult> OnPost()
        {
            var user = await _userManager.FindByNameAsync(Login.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, Login.Password))
            {

                string newtoken=TokenCreation(user.UserName);
                HttpContext.Session.SetString("token", newtoken);
                HttpContext.Session.SetString("username",user.UserName);
                return  Redirect(user.UserName);
            }
            
            return Unauthorized();
        }

        public new ActionResult Redirect(string username)
        {
            string path = "";
            int prix;
            short numero;
            int id = 0;
            try
            {
                path = (string)HttpContext.Session.GetString("redirectionpath");
                prix = (int)HttpContext.Session.GetInt32("prix");
                numero = (short)HttpContext.Session.GetInt32("numchambre");
                id = _client.GetClientId(username);
            }
            catch
            {
                return RedirectToPage("../Reservations/CreateReservation");
            }
            if (path == null)
            {
                return RedirectToPage("../Reservations/CreateReservation");
            }
            return RedirectToPage(path, new { idclient=id, chambreNumero = numero, prixTotal = prix });
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