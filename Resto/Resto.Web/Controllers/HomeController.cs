using Resto.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resto.Web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;
        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.getAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}