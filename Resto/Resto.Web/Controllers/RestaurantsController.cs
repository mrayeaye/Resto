﻿using Resto.Data.Models;
using Resto.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resto.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.getAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.get(id);
            if (model == null)
                return View("NotFound");
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant rest)
        {
            db.Add(rest);
            return View();
        }
    }
}