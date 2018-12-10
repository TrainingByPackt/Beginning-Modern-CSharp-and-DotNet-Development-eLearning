using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //Exercise: Pass a parameter using a query string
        public IActionResult ProductsThatCostMoreThan(decimal? price)
        {
            if (!price.HasValue)
            {
                return NotFound("You must pass a product price in the query string, f or example, / Home / ProductsThatCostMoreThan ? price = 50");
            }
            var model = db.Products.Include(p => p.Category).Include(p => p.Supplier).Where(p => p.UnitPrice >
            price).ToArray();
            if (model.Count() == 0)
            {
                return NotFound($"No products cost more than { price: C}.");
            }
            ViewData["MaxPrice"] = price.Value.ToString("C");
            return View(model); // pass model to view
        }
        // Exercise: Pass parameters using a route value
        public IActionResult ProductDetail(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound("You must pass a product ID in " +
                                "the route, for example, / Home / ProductDetail / 21");
            }
            var model = db.Products.SingleOrDefault(p =>
            p.ProductID == id);
            if (model == null)
            {
                return NotFound($"A product with the ID of {id} was " +
                                $"found.");
            }
            return View(model); // pass model to view
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
