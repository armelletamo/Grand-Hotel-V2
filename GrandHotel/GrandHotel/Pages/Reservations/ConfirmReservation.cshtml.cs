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
        public int prix;
        public Reservation reservation { get; set; }
        public Chambre MaChambre;
        public ConfirmReservationModel(IReservation reservation)
        {
            _reservation = reservation;
        }

     
        public IActionResult OnGet(short chambreNumero, int prixTotal)
        {
            try
            {
                reservation = HttpContext.Session.GetObjectFromJson<Reservation>("Reservation");
                prix = prixTotal;
                _reservation.SaveReservation(reservation, chambreNumero);
            }
            catch(Exception ex)
            {
                return RedirectToPage("./UnableToSave");
            }
            return Page();
        }
    }
}