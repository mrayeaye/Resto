using Resto.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resto.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestoDbContext db;

        public SqlRestaurantData(RestoDbContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant rest)
        {
            db.Restaurants.Add(rest);
            db.SaveChanges();
        }

        public Restaurant get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> getAll()
        {
            return db.Restaurants;
        }

        public void Update(Restaurant rest)
        {
            var entry = db.Entry(rest);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
