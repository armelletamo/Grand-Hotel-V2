using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandHotel.Data.Repository.Interface
{
    public interface ILogin
    {
        bool CheckToken(string token);

        void SaveLogoutToken(LogoutToken token);
    }
}
