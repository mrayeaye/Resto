using Resto.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Data.Services
{
    public class RestoDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants {get; set;}
    }
}
