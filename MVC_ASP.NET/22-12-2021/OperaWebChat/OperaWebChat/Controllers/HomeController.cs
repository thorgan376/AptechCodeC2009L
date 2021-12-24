using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperaWebChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ContentResult GetBackground()
        {
            string style;
            if (Session["BackgroundColor"] != null)
            {
                style = String.Format("background-color: {0};", Session["BackgroundColor"]);
            }
            else
            {
                style = "background-color: #dc9797;";
            }

            return Content(style);
        }

        public ActionResult SetBackground(string color)
        {
            Session["BackgroundColor"] = color;
            return View("Index");
        }

        public ActionResult Chat(string color)
        {
            return View();
        }
    }
}