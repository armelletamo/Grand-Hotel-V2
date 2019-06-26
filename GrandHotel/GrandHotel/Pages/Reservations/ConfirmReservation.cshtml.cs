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

     
        public IActionResult OnGet([FromBody]int idclient, [FromBody]short chambreNumero, [FromBody]int prixTotal, [FromBody]Facture facturereservation)
        {
            try
            {
                reservation = HttpContext.Session.GetObjectFromJson<Reservation>("Reservation");
                prix = prixTotal;
                numero = chambreNumero;
                _reservation.SaveReservation(reservation,idclient, chambreNumero);
                _facture.SaveBills(idclient, facturereservation);
            }
            catch(Exception ex)
            {
                return RedirectToPage("./UnableToSave");
            }
            return Page();
        }
    }
}