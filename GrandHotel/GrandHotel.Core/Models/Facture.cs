using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GrandHotel.Core.Models
{
    public partial class Facture
    {
        public Facture()
        {
            LigneFacture = new HashSet<LigneFacture>();
        }

        public int Id { get; set; }
        public int IdClient { get; set; }
        [BindRequired]
        [DisplayName("Invoice Date")]
        public DateTime DateFacture { get; set; }
        [BindRequired]
        [DisplayName("Date of the payment of the invoice")]
        public DateTime? DatePaiement { get; set; }
        [BindRequired]
        [DisplayName("Pay Mode")]
        public string CodeModePaiement { get; set; }

        public ModePaiement CodeModePaiementNavigation { get; set; }
        public Client IdClientNavigation { get; set; }
        public ICollection<LigneFacture> LigneFacture { get; set; }
    }
}
