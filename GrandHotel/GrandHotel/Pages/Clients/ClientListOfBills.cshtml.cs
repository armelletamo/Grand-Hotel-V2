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
    public class ClientListOfBillsModel : PageModel
    {
        private readonly IClient _client;
        private readonly IFacture _facture;
        public IEnumerable<Facture> ListOfFacture;
        [BindProperty(SupportsGet = true)]
        public int Year { get; set; }

        public ClientListOfBillsModel(IClient client, IFacture newfacture)
        {
            _client = client;
            _facture = newfacture;
        }
        public IActionResult OnGet(int year)
        {
            string username = HttpContext.User.Identities.FirstOrDefault().Claims.FirstOrDefault().Value;
            try
            {
                int id = _client.GetClient(username).Id;

                if (year != DateTime.Now.Year)
                {
                    ListOfFacture = _facture.GetBills(id, Year);
                    return Page();
                }
                ListOfFacture = _facture.GetBills(id, year);
                
            }
            catch (Exception)
            {

            }
            return Page();
        }
    }
}