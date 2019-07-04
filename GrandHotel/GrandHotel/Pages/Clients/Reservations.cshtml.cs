using System;
using System.Collections.Generic;
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

        public ReservationsModel(IClient client)
        {
            _client = client;
        }
        public IActionResult OnGet(string email)
        {
            clt=_client.MyReservation(email);
            if (clt.Reservation.Count != 0)
            {

                return Page();
            }
            return RedirectToPage("./NoReservation");

        }
    }
}