using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandHotel.Data.Repository
{
    public class FactureData: IFacture
    {
        private readonly GrandHotelContext db;
        public FactureData(GrandHotelContext db)
        {
            this.db = db;
        }

        public IEnumerable<Facture> GetBills(int id)
        {
          return  db.Facture.Where(x => x.IdClient == id).ToList();
        }

        public void SaveBills(int idclient, Facture facture)
        {
           var client= db.Client.Where(x => x.Id == idclient).FirstOrDefault();
            client.Facture.Add(facture);
            db.SaveChanges();
        }

        public LigneFacture GetBillsDetail(int id)
        {
            var detail = db.LigneFacture.Where(x=>x.IdFacture==id).FirstOrDefault();
            return detail;
            
        }


    }
}
