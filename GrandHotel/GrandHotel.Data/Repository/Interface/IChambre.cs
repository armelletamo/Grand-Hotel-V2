using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotel.Data.Repository.Interface
{
    public interface IChambre
    {
        IEnumerable<Chambre> ChambresDisponible(IEnumerable<Reservation>reservations, int nbpersonne, int nbnuit);
        Chambre DetailChambre(int chambreid, int prix, int prixtotal, int Nbnuit);
       
    }
}
