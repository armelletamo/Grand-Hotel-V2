using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Cookies;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Clients
{
    [Authorize]
    public class BillsModel : PageModel
    {
        private readonly IClient _client;
        private readonly IFacture _facture;

        [BindProperty(SupportsGet = true)]
        public Facture facture { get; set; }

        [BindProperty(SupportsGet = true)]
        public LigneFacture ligneFacture { get; set; }
        public Reservation res { get; set; }

        public IEnumerable<Facture> ListOfFacture;
        
        [BindProperty]
        public string save { get; set; }
        [BindProperty]
        public string cancel { get; set; }

        [BindProperty(SupportsGet = true) ]
        public string username { get; set; }

        public int prixtotal;
        public int prixht;

        public BillsModel(IClient client, IFacture newfacture)
        {
            _client = client;
            facture = new Facture();
            _facture = newfacture;
        }

        public IActionResult OnGet(string email)
        {
            prixtotal = (int)HttpContext.Session.GetInt32("prix");
            prixht = (int)Math.Ceiling(prixtotal / 1.188);
            res = HttpContext.Session.GetObjectFromJson<Reservation>("Reservation");
            facture.DateFacture = res.Jour.Date;
            facture.DatePaiement = DateTime.Now.Date;
            ligneFacture.Quantite = (short)res.NombreDeJour;
            ligneFacture.MontantHt = prixht / ligneFacture.Quantite;
            ViewData["email"] = email;
            return Page();
        }
        public IActionResult OnPost(string username)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(save))
                {
                    prixtotal = (int)HttpContext.Session.GetInt32("prix");
                    int id = _client.GetClient(username).Id;
                    short numero = (short)HttpContext.Session.GetInt32("numchambre");
                    HttpContext.Session.SetObjectAsJson("Facture", facture);
                    HttpContext.Session.SetObjectAsJson("LigneFacture", ligneFacture);
                    return RedirectToPage("../Reservations/ConfirmReservation", new { idclient = id, chambreNumero = numero, prixTotal = prixtotal });
                }
                else if(!string.IsNullOrEmpty(cancel))
                {
                    HttpContext.Session.Remove("Reservation");
                    HttpContext.Session.Remove("ListeDeChambre");
                    return RedirectToPage("../Reservations/CreateReservation");
                }
               
            }

            return Page();
        }

       

    }
}