using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Cookies;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Clients
{
    public class BillsModel : PageModel
    {
        private readonly IClient _client;
        [BindProperty(SupportsGet = true)]
        public Facture facture { get; set; }

        [BindProperty(SupportsGet = true)]
        public LigneFacture ligneFacture { get; set; }
        public Reservation res { get; set; }
        public int prixtotal;

        public BillsModel(IClient client)
        {
            _client = client;
            prixtotal = (int)HttpContext.Session.GetInt32("prix");
        }

        public IActionResult OnGet([FromBody] string username)
        {
            res = HttpContext.Session.GetObjectFromJson<Reservation>("Reservation");            
            ViewData["email"] = username;
            return Page();
        }
        public IActionResult OnPost([FromBody] string username)
        {
            if (ModelState.IsValid)
            {
                int id = _client.GetClient(username).Id;
                facture.LigneFacture.Add(ligneFacture);
                short numero= (short)HttpContext.Session.GetInt32("numchambre");
                return RedirectToPage("../Reservations/ConfirmReservation", new { idclient = id, chambreNumero = numero, prixTotal = prixtotal, facturereservation = facture }) ;
            }
           
            return Page();
        }
    }
}