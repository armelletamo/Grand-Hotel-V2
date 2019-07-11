using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandHotel.Data.Repository.Interface
{
    public interface IFacture
    {
        int SaveBills(int idclient, Facture facture);

        IEnumerable<Facture> GetBills(int id, int year);

        LigneFacture GetBillsDetail(int id);

        void SaveLigneFacture(int id, LigneFacture ligne);

       
    }
}
