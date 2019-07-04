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

        public int SaveBills(int idclient, Facture facture)
        {
           var client= db.Client.Where(x => x.Id == idclient).FirstOrDefault();
            client.Facture.Add(facture);
            db.SaveChanges();
            return db.Facture.Where(x => x.IdClient == idclient).Select(x => x.Id).LastOrDefault();
        }

        public LigneFacture GetBillsDetail(int id)
        {
            var detail = db.LigneFacture.Where(x=>x.IdFacture==id).FirstOrDefault();
            return detail;
            
        }

        public void SaveLigneFacture(int id, LigneFacture ligne)
        {
            int numligne = db.LigneFacture.Where(x => x.IdFacture == id).Count();
            ligne.NumLigne = numligne+1;
            var fact = db.Facture.Where(x => x.Id == id).FirstOrDefault();
            fact.LigneFacture.Add(ligne);
            db.SaveChanges();
        }
    }
}
