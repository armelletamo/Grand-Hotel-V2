using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrandHotel.Core.Models
{
    public partial class Chambre
    {
        public Chambre()
        {
            Reservation = new HashSet<Reservation>();
            TarifChambre = new HashSet<TarifChambre>();
        }

        public short Numero { get; set; }
        public byte Etage { get; set; }
        public bool Bain { get; set; }
        public bool? Douche { get; set; }
        public bool? Wc { get; set; }
        public byte NbLits { get; set; }
        public short? NumTel { get; set; }
        [NotMapped]
        public int Prix { get; set; }     
        [NotMapped]
        public int NbNuit { get; set; }
        [Display(Name = "Prix Total")]
        [NotMapped]
        public int PrixTotal { get; set; }
        [JsonIgnore]
        public ICollection<Reservation> Reservation { get; set; }
        [JsonIgnore]
        public ICollection<TarifChambre> TarifChambre { get; set; }
    }
}
