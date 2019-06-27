using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandHotel.Data.Repository.Interface
{
    public interface IFacture
    {
        void SaveBills(int idclient, Facture facture);

        IEnumerable<Facture> GetBills(int id);

        LigneFacture GetBillsDetail(int id);
    }
}
