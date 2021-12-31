using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAD_C2009L_NguyenVanA.Models;
/*
 Database Code-First 
    
*/
namespace WAD_C2009L_NguyenVanA.Controllers
{
    public class HomeController : MyController
    {
        private DataContext dataContext = new DataContext();
        public ActionResult Index()
        {
            List<Student> students =  dataContext.Students.ToList();
            return View();
        }
        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageManager().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
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