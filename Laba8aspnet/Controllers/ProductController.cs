using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Laba8aspnet.Models;

namespace Laba8aspnet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
           
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 10.99m, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Product 2", Price = 15.99m, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Product 3", Price = 20.99m, CreatedDate = DateTime.Now }
            };

           
            return View(products);
        }
    }
}
