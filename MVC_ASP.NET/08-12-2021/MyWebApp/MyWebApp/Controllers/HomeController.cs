using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //receive request from client
            Product productA = new Product()
            {
                ProductName = "macbook pro 2022",
                Year = 2022,
                Price = 123.33,
                Description = "This is the laptop I like"
            };            
            //this is a list
            List<Student> students = new List<Student>()
            {
                new Student() { 
                    StudentName = "Nguyen Van A",
                    DateOfBirth = new DateTime(2008, 12, 1),
                    Email = "nva@gmail.com"
                },
                new Student() {
                    StudentName = "Nguyen Van C",
                    DateOfBirth = new DateTime(2011, 10, 15),
                    Email = "nguyenvanc@gmail.com"
                },
                new Student() {
                    StudentName = "Nguyen Van B",
                    DateOfBirth = new DateTime(2010, 12, 12),
                    Email = "bnguyevan@gmail.com"
                }
            };
            ViewBag.productA = productA;
            ViewBag.students = students;
            //ViewData["productA"] = productA;
            return View(); //Home/Index.cshtml
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