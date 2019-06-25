using GrandHotel.Core.Models;
using GrandHotel.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandHotel.Data.Repository
{
   public  class LoginData:ILogin
    {
        private readonly GrandHotelContext db;
        public LoginData(GrandHotelContext db)
        {
            this.db = db;
        }

        public bool CheckToken(string token)
        {
            return db.LogoutToken.Any(x => x.Token == token);
        }

        public void SaveLogoutToken(LogoutToken token)
        {
            db.LogoutToken.Add(token);
            db.SaveChanges();
        }
    }
}
