using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandHotel.Data.Repository
{
    public class ClientData:IClient
    {
        private readonly GrandHotelContext db;
        public ClientData(GrandHotelContext db)
        {
            this.db = db;
        }

        public void CreateClient(Client client)
        {
            
            db.Client.Add(client);
            db.SaveChanges();
            
        }

        public int GetClientId(string username)
        {
            int idclient = 0;
            idclient = db.Client.Where(x => x.Email == username).Select(x => x.Id).FirstOrDefault();
            return idclient;
        }
    }
}
