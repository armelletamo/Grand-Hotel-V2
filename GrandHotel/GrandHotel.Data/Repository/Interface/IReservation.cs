using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotel.Data.Repository.Interface
{
   public  interface IReservation
    {
         IEnumerable<Reservation> GetReservation(Reservation reservation );
        void SaveReservation(Reservation reservation, short numero);
    }
}
