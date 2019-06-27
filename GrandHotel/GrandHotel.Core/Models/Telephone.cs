using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace GrandHotel.Core.Models
{
    public partial class Telephone
    {
        [Display(Name = "Phone Number")]
        public string Numero { get; set; }
        public int IdClient { get; set; }
        [Display(Name = "Fixe or Portable")]
        public string CodeType { get; set; }
        public bool Pro { get; set; }

        public Client IdClientNavigation { get; set; }
    }
}
