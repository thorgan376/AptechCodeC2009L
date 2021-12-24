using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //This is a list of Products as "model" object
            //donot use ViewBag/ViewData
            List<Product> products = new List<Product>()
            {
                new Product() { 
                    ProductName = "iphone 3",
                    Year = 2013,
                    Price = 111.22,
                },
                new Product() {
                    ProductName = "iphone 4",
                    Year = 2014,
                    Price = 222.22,
                },
                new Product() {
                    ProductName = "iphone 5",
                    Year = 2015,
                    Price = 333.22,
                },
                new Product() {
                    ProductName = "iphone 4",
                    Year = 2013,
                    Price = 4444.22,
                }
            };
            return View(products);//Product/Index.html
        }
    }
}