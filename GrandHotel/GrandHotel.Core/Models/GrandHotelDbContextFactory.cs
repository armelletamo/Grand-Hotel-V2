using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrandHotel.Core.Models
{
    public class GrandHotelDbContextFactory : IDesignTimeDbContextFactory<GrandHotelContext>
    {
        public GrandHotelContext CreateDbContext(string[] args)
        {
                var builder = new DbContextOptionsBuilder<GrandHotelContext>();

            var connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GrandHotel; Trusted_Connection = True; ";

                builder.UseSqlServer(connectionString);

                return new GrandHotelContext(builder.Options);
            
        }
    }
}
