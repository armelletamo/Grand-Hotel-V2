using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GrandHotel.Data.Repository
{
    public class ReservationData : IReservation
    {
        private readonly GrandHotelContext db;
        private IEnumerable<Reservation> _reservation;

        public ReservationData(GrandHotelContext db)
        {
            this.db = db;

        }

        public IEnumerable<Reservation> GetReservation(Reservation reservation)
        {
            _reservation = db.Reservation
                .Include(r => r.NumChambreNavigation)
                           .Where(r => r.Jour == reservation.Jour || r.Jour == reservation.Jour.AddDays(reservation.NombreDeJour - 1) && r.NbPersonnes == reservation.NbPersonnes)
                           .GroupBy(c => c.NumChambre)
                           .Select(x => x.First());
            foreach (var res in _reservation)
            {
                res.NombreDeJour = reservation.NombreDeJour;
            }
            return _reservation;


        }

        public void SaveReservation(Reservation reservation, int idclient, short numero)
        {

            var client = db.Client.AsNoTracking().Where(x => x.Id == idclient).FirstOrDefault();
            for (int i = 0; i < reservation.NombreDeJour; i++)
            {
                Reservation res = new Reservation();
                res.NumChambre = numero;
                res.NbPersonnes = reservation.NbPersonnes;
                res.Travail = reservation.Travail;
               res.JourNavigation = db.Calendrier.Where(x=>x.Jour==reservation.Jour.AddDays(i)).FirstOrDefault();
                res.HeureArrivee = reservation.HeureArrivee;
                client.Reservation.Add(res);
                db.Update(client);
                db.SaveChanges();

            }




        }
    }
}