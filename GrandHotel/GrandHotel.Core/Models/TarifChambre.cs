using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GrandHotel.Core.Models
{
    public partial class TarifChambre
    {
        public short NumChambre { get; set; }
        public string CodeTarif { get; set; }
        [JsonIgnore]
        public Tarif CodeTarifNavigation { get; set; }
        public Chambre NumChambreNavigation { get; set; }
    }
}
