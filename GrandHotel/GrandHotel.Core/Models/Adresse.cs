using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        [DisplayName("Postal Code")]
        public string CodePostal { get; set; }
        [DisplayName("Town")]
        public string Ville { get; set; }

        public Client IdClientNavigation { get; set; }
    }
}
