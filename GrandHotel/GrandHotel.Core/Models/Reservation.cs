using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandHotel.Core.Models
{
    public partial class Reservation
    {
        public short NumChambre { get; set; }

        [Display(Name = "Date d'arrivée")]
        [Required]
        public DateTime Jour { get; set; }

        public int IdClient { get; set; }

        [Display(Name = "Nombre de personne")]
        [Required]
        public byte NbPersonnes { get; set; }

        [Display(Name = "Nombre de jour")]
        [NotMapped]
        [Required]
        public int NombreDeJour { get; set; }

        [Display(Name = "Heure d'arrivée")]
        [Required]
        public byte HeureArrivee { get; set; }

        [Display(Name = "Séjour pour travail?")]
        public bool? Travail { get; set; }

        [Display(Name = "Petit-dejeûner?")]
        [NotMapped]        
        public bool Dej { get; set; }

        public Client IdClientNavigation { get; set; }
        public Calendrier JourNavigation { get; set; }
        public Chambre NumChambreNavigation { get; set; }
    }
}
