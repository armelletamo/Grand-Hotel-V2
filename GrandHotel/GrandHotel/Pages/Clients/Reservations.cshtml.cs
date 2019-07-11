using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class ReservationsModel : PageModel
    {
        private readonly IClient _client;

        [BindProperty(SupportsGet = true)]
        public Client clt { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<Reservation> reservations { get; set; }
        public ReservationsModel(IClient client)
        {
            _client = client;
            reservations = new List<Reservation>();
        }
        public IActionResult OnGet()
        {
            string username = HttpContext.User.Identities.FirstOrDefault().Claims.FirstOrDefault().Value;
            clt = _client.MyReservation(username);
            if (clt.Reservation.Count != 0)
            {
                foreach (var res in clt.Reservation)
                {
                    if (res.NombreDeJour != 0)
                    {
                        reservations.Add(res);
                    }
                }
                return Page();
            }
            return RedirectToPage("./NoReservation");

        }

        public IActionResult OnPost(int idclient, string date, int nbjour)
        {
            if (idclient != 0 && nbjour != 0)
            {
                var newdate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                return RedirectToPage("./CancelReservation", new { idclt = idclient, d = newdate, nbj = nbjour });
            }
            TempData["unabletocancel"] = "Sorry we are unable to cancel the reservation.please try again or call our customer service. Thanks!";
            return RedirectToPage("../Reservations/CreateReservation");
        }
    }
}