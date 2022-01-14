using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HumanController : Controller
    {
        // GET: Human
        public ActionResult Index()
        {
            return View();
        }
    }
}