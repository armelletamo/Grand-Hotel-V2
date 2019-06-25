using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Authentication
{
    public class LogoutModel : PageModel
    {
        private readonly ILogin _log;


        public LogoutModel(ILogin log)
        {
            _log = log;
        }
        public IActionResult OnPost(string username)
        {
            LogoutToken t = new LogoutToken();
            t.Username = username;
            t.Token = HttpContext.Session.GetString("token");
            _log.SaveLogoutToken(t);
            HttpContext.Session.Remove("token");
            return RedirectToPage("../Index");
        }
    }
}