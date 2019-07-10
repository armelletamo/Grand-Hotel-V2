using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Chambres
{
    public class DetailModel : PageModel
    {
        private readonly IChambre _chambre;

        public Chambre NewChambre { get; set; }

        public DetailModel(IChambre chambre)
        {
            _chambre = chambre;
        }

        public IActionResult OnGet(int chambreId, int Prix, int prixTotal, int nbnuit)
        {
            NewChambre = _chambre.DetailChambre(chambreId, Prix, prixTotal, nbnuit);
            if (NewChambre == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}