using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace GrandHotel.Pages.Authentication
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        [BindProperty]
        public RegisterViewModel Register { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, IConfiguration configuration)
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
            if (Register != null)
            {
                var user = new IdentityUser
                {
                    Email = Register.Email,
                    UserName = Register.Email,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var result = await _userManager.CreateAsync(user, Register.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Customer");
                }
                var Username = user.UserName;

                return RedirectToPage("../Clients/CreateClient", new { email = Username });

            }


            return Page();
        }
    }
}