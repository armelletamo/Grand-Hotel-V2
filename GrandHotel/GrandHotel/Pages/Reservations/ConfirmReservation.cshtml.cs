using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Cookies;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages.Reservations
{
    [Authorize]
    public class ConfirmReservationModel : PageModel
    {
        private readonly IReservation _reservation;
        private readonly IFacture _facture;
        public int prix;
        public short numero;
        public Reservation reservation;
        public Chambre MaChambre;
        public ConfirmReservationModel(IReservation reservation, IFacture facture)
        {
            _reservation = reservation;
            _facture = facture;
        }


        public IActionResult OnGet(int idclient, short chambreNumero, int prixTotal)
        {
            try
            {
                reservation = HttpContext.Session.GetObjectFromJson<Reservation>("Reservation");
                prix = prixTotal;
                numero = chambreNumero;

                _reservation.SaveReservation(reservation, idclient, chambreNumero);
                var factuereservation = HttpContext.Session.GetObjectFromJson<Facture>("Facture");
                int factureid = _facture.SaveBills(idclient, factuereservation);
                var LigneFacture = HttpContext.Session.GetObjectFromJson<LigneFacture>("LigneFacture");
                _facture.SaveLigneFacture(factureid, LigneFacture);

                HttpContext.Session.Remove("Reservation");
                HttpContext.Session.Remove("Facture");
                HttpContext.Session.Remove("LigneFacture");
            }
            catch (Exception ex)
            {
                return RedirectToPage("./UnableToSave");
            }
            return Page();
        }
    }
}