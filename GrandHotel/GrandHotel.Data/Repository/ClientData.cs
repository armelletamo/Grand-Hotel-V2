using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandHotel.Data.Repository
{
    public class ClientData : IClient
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

        public Client GetClient(string username)
        {
            return db.Client.Where(x => x.Email == username).FirstOrDefault();
        }

        public Client GetDetails(string email)
        {
            return db.Client
                .Include(x => x.Adresse)
                .Include(x => x.Telephone)
                .Where(x => x.Email == email)
                .FirstOrDefault();
        }

        public Client MyReservation(string email)
        {
            return db.Client
                .Include(x => x.Reservation)
                .Where(x => x.Email == email)
                .FirstOrDefault();
        }

        public void RemoveFacture(int idclient, DateTime date)
        {
            var client = db.Client.Include(x=>x.Facture).AsNoTracking().Single(x => x.Id == idclient);
            var fact = client.Facture.Where(x => x.DateFacture == date && x.IdClient==idclient).FirstOrDefault();
            var lignefact = db.LigneFacture.Single(x => x.IdFacture == fact.Id);
            db.LigneFacture.Remove(lignefact);
            client.Facture.Remove(fact);
            db.Facture.Remove(fact);
            db.SaveChanges();


        }

        public void RemoveReservation(int idclient, int nbjour, DateTime date)
        {
            var client = db.Client.AsNoTracking().Single(x => x.Id == idclient);

            for (int i = 0; i < nbjour; i++)
            {
                var reserv = db.Reservation.Single(x => x.Jour == date.AddDays(i));
                client.Reservation.Remove(reserv);
                db.Reservation.Remove(reserv);
                db.SaveChanges();

            }


        }

        public void UpdateClient(Client clt)
        {
            var client = db.Client.Where(x => x.Id == clt.Id).Include(x => x.Adresse)
                 .Include(x => x.Telephone).FirstOrDefault();
            if (client != null)
            {
                client = clt;
                db.SaveChanges();
            }

        }
    }
}
