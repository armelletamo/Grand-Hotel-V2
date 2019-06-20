using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GrandHotel.Data.Repository
{
    public class AddData
    {
        private readonly GrandHotelContext db;
        public AddData(GrandHotelContext db)
        {
            this.db = db;
        }
        public  void adddata()
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            var reserv = new List<Reservation>() {
            new Reservation() { NumChambre = 1, Jour= DateTime.ParseExact("2019-01-01", "yyyy-MM-dd", ci), IdClient=2, NbPersonnes=2, HeureArrivee=18  },//Child entity (empty key)
            new Reservation() { NumChambre = 5, Jour= DateTime.ParseExact("2019-02-25", "yyyy-MM-dd", ci), IdClient=5, NbPersonnes=1, HeureArrivee=15  },//Child entity (empty key)
          new Reservation() { NumChambre = 10, Jour= DateTime.ParseExact("2019-01-25", "yyyy-MM-dd", ci), IdClient=15, NbPersonnes=3, HeureArrivee=6  },//Child entity (empty key)
                 new Reservation() { NumChambre = 20, Jour= DateTime.ParseExact("2019-02-03", "yyyy-MM-dd", ci), IdClient=65, NbPersonnes=2, HeureArrivee=7  },//Child entity (empty key)
    new Reservation() { NumChambre = 15, Jour= DateTime.ParseExact("2019-03-05", "yyyy-MM-dd", ci), IdClient=12, NbPersonnes=3, HeureArrivee=10  },//Child entity (empty key)
  new Reservation() { NumChambre = 5, Jour= DateTime.ParseExact("2019-02-16", "yyyy-MM-dd", ci), IdClient=56, NbPersonnes=3, HeureArrivee=17  },//Child entity (empty key)
 new Reservation() { NumChambre = 5, Jour= DateTime.ParseExact("2019-04-18", "yyyy-MM-dd", ci), IdClient=35, NbPersonnes=2, HeureArrivee=15  },//Child entity (empty key)
  new Reservation() { NumChambre = 5, Jour= DateTime.ParseExact("2019-03-19", "yyyy-MM-dd", ci), IdClient=13, NbPersonnes=1, HeureArrivee=13  },//Child entity (empty key)
  new Reservation() { NumChambre = 5, Jour= DateTime.ParseExact("2019-02-20", "yyyy-MM-dd", ci), IdClient=14, NbPersonnes=1, HeureArrivee=6  },
            };

            foreach(var data in reserv)
            {
                db.Reservation.Add(data);
                db.SaveChanges();
            }
        }
    }
}






