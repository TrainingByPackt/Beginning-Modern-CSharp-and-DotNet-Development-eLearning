using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using static System.Console;
using Packt.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {

                //var loggerFactory = db.GetService<ILoggerFactory>(); // Activity B-2
                //loggerFactory.AddProvider(new ConsoleLogProvider()); // Activity B-2

                WriteLine("List of categories and the number of products:");

                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }

                WriteLine("List of products that cost more than a given price with most expensive first.");
                string input;
                decimal price;
                do
                {
                    Write("Enter a product price: ");
                    input = ReadLine();
                } while (!decimal.TryParse(input, out price));

                IQueryable<Product> prods = db.Products.Where(product => product.UnitPrice > price).OrderByDescending(product => product.UnitPrice);

                foreach (Product item in prods)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }

                //// Start Activity B-3
                //var newProduct = new Product
                //{
                //    CategoryID = 6, // Meat & Poultry
                //    ProductName = "Bob's Burger",
                //    UnitPrice = 500M
                //};
                //// mark product as added in change tracking
                //db.Products.Add(newProduct);
                //// save tracked changes to database
                //db.SaveChanges();
                //foreach (var item in db.Products)
                //{
                //    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                //}
                //// End Activity B-3

                // Start Activity B-4
                Product updateProduct = db.Products.First(p => p.ProductName.StartsWith("Bob"));
                updateProduct.UnitPrice += 20M;
                db.SaveChanges();
                foreach (var item in db.Products)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }
                // End Activity B-4
            }
        }
    }
}
