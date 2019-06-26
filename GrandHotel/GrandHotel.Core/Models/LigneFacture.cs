using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GrandHotel.Core.Models
{
    public partial class LigneFacture
    {
        public int IdFacture { get; set; }
        public int NumLigne { get; set; }
        [BindRequired]
        [DisplayName("Number of day")]
        public short Quantite { get; set; }
        [BindRequired]
        [DisplayName("Pre-Tax Amount")]
        public decimal MontantHt { get; set; }
        [BindRequired]
        [DisplayName("Tax Percentage")]
        public decimal TauxTva { get; set; }
        [BindRequired]
        [DisplayName("Reduction Percentage")]
        public decimal TauxReduction { get; set; }

        public Facture IdFactureNavigation { get; set; }
    }
}
