using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GrandHotel.Core.Models
{
    public partial class Client
    {
        public Client()
        {
            Facture = new HashSet<Facture>();
           Reservation = new List<Reservation>();
            Telephone = new HashSet<Telephone>();
        }

        public int Id { get; set; }
        [BindRequired]
        [DisplayName("Civility")]
        public string Civilite { get; set; }
        [DisplayName("Last Name")]
        [BindRequired]
        public string Nom { get; set; }
        [DisplayName("First Name")]
        [BindRequired]
        public string Prenom { get; set; }
        [BindRequired]
        public string Email { get; set; }
        [DisplayName("Fidelity Card")]
        [BindRequired]
        public bool CarteFidelite { get; set; }
        [DisplayName("Society")]
        [BindRequired]
        public string Societe { get; set; }

        public Adresse Adresse { get; set; }
        public ICollection<Facture> Facture { get; set; }
        public List<Reservation> Reservation { get; set; }
        public ICollection<Telephone> Telephone { get; set; }
    }
}
