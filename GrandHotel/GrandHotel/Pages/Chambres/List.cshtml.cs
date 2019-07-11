﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Cookies;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace GrandHotel.Pages.Chambres
{
    public class ListModel : PageModel
    {
        [BindProperty]
        public PaginatedList<Chambre> Chambres { get; set; }

        public IEnumerable<Chambre> Chambre;
       // PaginatedList<Chambre> PageListChambre;

        public IActionResult OnGet(int? pageNumber)
        {
            int pagesize = 5;
            var listeDeChambre = HttpContext.Session.GetObjectFromJson<IEnumerable<Chambre>>("ListeDeChambre");
            if (listeDeChambre != null)
            {                              
                Chambre = listeDeChambre;
                Chambres = PaginatedList<Chambre>.Create(Chambre, pageNumber ?? 1, pagesize);
                return Page();
            }
            return RedirectToPage("../Reservations/CreateReservation");

        }


        public IActionResult OnPost(short numchambre, int prix)
        {
            ViewData["redirectionpath"] = "../Reservations/ConfirmReservation";
            ViewData["numchambre"] = numchambre;
            ViewData["prix"] = prix;

            HttpContext.Session.SetString("redirectionpath", "../Reservations/ConfirmReservation");
            HttpContext.Session.SetInt32("prix", prix);
            HttpContext.Session.SetInt32("numchambre", numchambre);

            var done = HttpContext.User.Identity.IsAuthenticated;
            if (done)
            {
                return RedirectToPage("../Clients/Bills");
            }
            return RedirectToPage("../Authentication/login");
        }
    }
}