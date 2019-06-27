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
    public class DetailOfBillModel : PageModel
    {
        private readonly IFacture _facture;
        public LigneFacture ligneFacture { get; set; }


        public DetailOfBillModel( IFacture newfacture)
        {
            _facture = newfacture;
        }

        public IActionResult OnGet(int id)
        {
            ligneFacture = _facture.GetBillsDetail(id);
            return Page();
        }
    }
}