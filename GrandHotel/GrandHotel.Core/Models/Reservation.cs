using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandHotel.Core.Models
{
    public partial class Reservation
    {
        public short NumChambre { get; set; }

        [Display(Name = "Arriving Day")]
        [Range(typeof(DateTime), "01/01/2018", "31/12/2023",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [BindRequired]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Jour { get; set; }

        public int IdClient { get; set; }

        [Display(Name = "Number of Persons")]       
        [BindRequired]
        [Range(1, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public byte NbPersonnes { get; set; }

        [Display(Name = "Number of Days")]
        [NotMapped]
        [BindRequired]
        public int NombreDeJour { get; set; }

        [BindRequired]
        [Range(6, 22, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Arriving Time")]
        public byte HeureArrivee { get; set; }

        [Display(Name = "For Works?")]
        public bool? Travail { get; set; }

        public Client IdClientNavigation { get; set; }
        public Calendrier JourNavigation { get; set; }
        public Chambre NumChambreNavigation { get; set; }
    }
}
