using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GrandHotel.Core.Models;
using GrandHotel.Pages.Chambres;

using Microsoft.Extensions.Configuration;
using GrandHotel.Cookies;
using Microsoft.AspNetCore.Http;

namespace GrandHotel.Pages.Reservations
{
    public class CreateReservationModel : PageModel
    {
        private readonly IReservation _reservation;
        private readonly IChambre _chambre;
        

        [BindProperty(SupportsGet = true)]
        public Reservation Reservation { get; set; }

        public CreateReservationModel(IReservation reservation, IChambre chambre)
        {
            _reservation = reservation;
            _chambre = chambre;           

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.Remove("Reservation");
                var MaReservation = _reservation.GetReservation(Reservation).ToList();
                var ChambreDispo = _chambre.ChambresDisponible(MaReservation, Reservation.NbPersonnes, Reservation.NombreDeJour);
                HttpContext.Session.SetObjectAsJson("Reservation", Reservation);
                HttpContext.Session.SetObjectAsJson("ListeDeChambre", ChambreDispo);
                return RedirectToPage("../Chambres/List", new { pageNumber = 1 });
            }
            return Page();
        }
    }
}