using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GrandHotel.Core.Models
{
    public partial class Adresse
    {
        public int IdClient { get; set; }
        [DisplayName("Street")]
        [BindRequired]
        public string Rue { get; set; }
        [BindRequired]
        public string Complement { get; set; }

        [StringLength(5, ErrorMessage = "The postal code value cannot exceed 5 characters. ")]
        [DisplayName("Postal Code")]
        public string CodePostal { get; set; }
        [DisplayName("Town")]
        public string Ville { get; set; }

        public Client IdClientNavigation { get; set; }
    }
}
