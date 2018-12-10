using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Packt.CS7;

namespace WebApp.Controllers
{

    public class HomeController : Controller
    {
        private Northwind db;
        public HomeController(Northwind injectedContext)
        {
            db = injectedContext;
        }

        /// <summary>
        /// We will simulate a visitor count using the Random class to generate a
        /// number between 1 and 1000.
        /// </summary>
        public IActionResult Index()
        {
            //return View();
            var model = new HomeIndexViewModel
            {
                VisitorCount = (new Random()).Next(1, 1001),
                Products = db.Products.ToArray()
            };
            return View(model); // pass model to view
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
