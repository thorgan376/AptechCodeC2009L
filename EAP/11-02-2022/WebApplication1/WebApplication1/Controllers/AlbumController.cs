using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class AlbumController : Controller
    {
        static readonly IAlbumRepository albumRepository = new AlbumRepository();
        public ActionResult Index()
        {
            return View();
        }
    }
}