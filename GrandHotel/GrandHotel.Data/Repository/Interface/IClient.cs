using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandHotel.Data.Repository.Interface
{
    public interface IClient
    {
        void CreateClient(Client client);

        Client GetClient(string username);

        Client GetDetails(string email);

        void UpdateClient(Client clt);

        Client MyReservation(string email);

        void RemoveReservation(int idclient, int nbjour, DateTime date);
        void RemoveFacture(int idclient, DateTime date);
    }
}
