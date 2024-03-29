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
    public class CancelReservationModel : PageModel
    {

        private readonly IClient _client;

        [BindProperty(SupportsGet = true)]
        public Client clt { get; set; }
        public CancelReservationModel(IClient client)
        {
            _client = client;
        }

       
        public IActionResult OnGet(int idclt, DateTime d, int nbj)
        {
            try
            {
                _client.RemoveReservation(idclt, nbj, d);
                _client.RemoveFacture(idclt, d);
                return Page();
            }
            catch
            {
                TempData["unabletocancel"] = "Sorry we are unable to cancel the reservation.please try again or call our customer service. Thanks!";
                return RedirectToPage("../Reservations/CreateReservation");
            }
            
        }
    }
}