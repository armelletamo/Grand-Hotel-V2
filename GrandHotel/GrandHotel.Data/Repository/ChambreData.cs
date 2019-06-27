using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Threading;

namespace GrandHotel.Data.Repository
{
    public class ChambreData : IChambre
    {
        private readonly GrandHotelContext db;
        private IEnumerable<Chambre> _chambre;
        public Chambre chambre;

        public ChambreData(GrandHotelContext db)
        {
            this.db = db;
            chambre = new Chambre();
        }

        public IEnumerable<Chambre> ChambresDisponible(IEnumerable<Reservation> reservations, int nbpersonne, int nbnuit)
        {
            List<Chambre> Chambredispo = new List<Chambre>();
            var listOfRooms = db.Chambre
                .Where(x => x.NbLits >= nbpersonne)
                .Include(chambre => chambre.TarifChambre)
                .ThenInclude(tarifchambre => tarifchambre.CodeTarifNavigation);

            if (reservations.Count() != 0)
            {
                var reservedRooms = reservations.Select(r => r.NumChambreNavigation);
                _chambre = listOfRooms.Where(p => !reservedRooms.Any(x => x.Numero == p.Numero)).ToList();
            }
            else
            {
                _chambre = listOfRooms.ToList();
            }
            foreach (var ch in _chambre)
            {
                ch.NbNuit = nbnuit;
                var codetarif = ch.TarifChambre.Where(x => x.CodeTarif.Contains("CHB") && x.CodeTarif.Contains("2018"));
                ch.Prix = (int)decimal.Truncate(ch.TarifChambre.Select(x => x.CodeTarifNavigation.Prix).FirstOrDefault());
                decimal d = Math.Ceiling(ch.Prix * ch.NbNuit * 1.188m);
                ch.PrixTotal = (int)decimal.Truncate(d);
                Chambredispo.Add(ch);
            }
            _chambre = Chambredispo;
            return _chambre;
        }


        public Chambre DetailChambre(int chambreid, int prix, int prixtotal, int Nbnuit)
        {
            var chambre = db.Chambre.Where(x => x.Numero == chambreid).FirstOrDefault();
            if (chambre != null)
            {
                chambre.Prix = prix;
                chambre.PrixTotal = prixtotal;
                chambre.NbNuit = Nbnuit;
            }
            return chambre;
        }
    }
}
