using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RazorLesson.Models;

namespace RazorLesson.Controllers {
    public class HomeController : Controller {
        
        public ViewResult Index() {
            Product kayak = new Product {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M,
            };

            ViewBag.StockLevel = 2;

            return View(kayak);
        }

        public ViewResult List() {
            Product[] products = {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Kayak 2", Price = 300M },
            };

            return View(products);
        }

    }
}