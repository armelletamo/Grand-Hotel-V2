using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Clients
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly IClient _client;

        [BindProperty(SupportsGet = true)]
        public Client clt { get; set; }
        [BindProperty(SupportsGet = true)]
        public Telephone tel { get; set; }
        public DetailsModel(IClient client)
        {
            _client = client;
        }
        public IActionResult OnGet(string email)
        {
           clt= _client.GetDetails(email);
            return Page();
        }

        public IActionResult OnPost()
        {
            clt.Telephone.Add(tel);
            _client.UpdateClient(clt);
            return Page();
        }
    }
}