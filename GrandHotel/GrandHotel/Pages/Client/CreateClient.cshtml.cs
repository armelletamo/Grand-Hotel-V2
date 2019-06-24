using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrandHotel.Pages
{
    public class CreateClientModel : PageModel
    {
        private readonly IClient _client;

        [BindProperty(SupportsGet = true)]
        public Adresse adresse { get; set; }

        [BindProperty(SupportsGet = true)]
        public Telephone telephone { get; set; }

        [BindProperty(SupportsGet = true)]
        public Client client { get; set; }
        public CreateClientModel(IClient clt)
        {
            _client = clt;
        }
        public ActionResult OnGet(string email)
        {

            client.Email = email;
            return Page();
           
        }

        public ActionResult OnPost()
        {
            try
            {
                if (client != null)
                {
                    client.Telephone.Add(telephone);
                    client.Adresse = adresse;
                    _client.CreateClient(client);
                }
               
            }
            catch
            {
                //return 
            }
            return RedirectToPage("../Authentication/Login");
        }
    }
}