﻿using GrandHotel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandHotel.Data.Repository.Interface
{
    public interface IClient
    {
        void CreateClient(Client client);

        int GetClientId(string username);
    }
}