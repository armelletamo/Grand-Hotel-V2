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

        public void SaveReservation(Reservation reservation,int idclient, short numero)
        {

            var client = db.Client.Where(x => x.Id == idclient).FirstOrDefault();
            Collection<Reservation> myReservation = new Collection<Reservation>();
            for (int i = 0; i < reservation.NombreDeJour; i++)
            {                
                reservation.NumChambre = numero;
                reservation.IdClient = idclient;
                reservation.Jour = reservation.Jour.AddDays(i);                
                myReservation.Add(reservation);                       
            }
            client.Reservation = myReservation;
            db.SaveChanges();
        }
    }
}
