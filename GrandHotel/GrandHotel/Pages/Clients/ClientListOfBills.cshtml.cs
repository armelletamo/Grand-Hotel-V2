using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Clients
{
    public class ClientListOfBillsModel : PageModel
    {
        private readonly IClient _client;
        private readonly IFacture _facture;
        public IEnumerable<Facture> ListOfFacture;

      
        public ClientListOfBillsModel(IClient client, IFacture newfacture)
        {
            _client = client;
            _facture = newfacture;
        }
        public IActionResult OnGet(string email)
        {
            int id = _client.GetClient(email).Id;
            ListOfFacture = _facture.GetBills(id);
            return Page();
        }
    }
}