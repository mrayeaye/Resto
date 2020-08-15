﻿using Resto.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resto.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> rests;

        public InMemoryRestaurantData()
        {
            rests = new List<Restaurant>()
            {
                new Restaurant{Id = 1,Name = "Dough Master", Cuisine = CuisineType.American},
                new Restaurant{Id = 2,Name = "Sayed Kofta", Cuisine = CuisineType.Egyptian},
                new Restaurant{Id = 3,Name = "Jamba Juice", Cuisine = CuisineType.American}
            };
        }
        public IEnumerable<Restaurant> getAll()
        {
            return rests.OrderBy(r => r.Name);
        }
    }
}
