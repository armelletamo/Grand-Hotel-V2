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

namespace GrandHotel.Pages.Authentication
{
    public class LoginModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        [BindProperty]
        public LoginViewModel Login { get; set; }
        public LoginModel(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
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
                var claim = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName)
                };
                var signinKey = new SymmetricSecurityKey(
                  Encoding.UTF8.GetBytes(_configuration["Jwt:SigningKey"]));

                int expiryInMinutes = Convert.ToInt32(_configuration["Jwt:ExpiryInMinutes"]);
      
                var token = new JwtSecurityToken(
                  issuer: _configuration["Jwt:Site"],
                  audience: _configuration["Jwt:Site"],
                  claims: claim,
                  notBefore: DateTime.Now,                
                  expires: DateTime.Now.AddMinutes(expiryInMinutes*3),
                  signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
                
                string newtoken = new JwtSecurityTokenHandler().WriteToken(token);
                var expiration = token.ValidTo;
                
                HttpContext.Request.Headers.Add("Authorization", "Bearer " + newtoken);

                string path = (string)HttpContext.Session.GetString("redirectionpath");
                int prix = (int)HttpContext.Session.GetInt32("prix");
                short numero = (short)HttpContext.Session.GetInt32("numchambre");
                if (path != null && path.Contains("Reservations"))
                {
                    return RedirectToPage(path, new { chambreNumero = numero, prixTotal = prix });
                }
                else
                {
                    return RedirectToPage(path);
                }
            }
            return Unauthorized();
        }
    }
}