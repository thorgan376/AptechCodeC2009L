using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EAP__C2009L.Models;
using Newtonsoft.Json.Linq;

namespace EAP__C2009L.Controllers
{
    public class JsonWSController : System.Web.Http.ApiController
    {
        private DataContext db = new DataContext();
        [HttpGet]
        public JToken Get()
        {
           var products = db.Products;
           string json = products.ToString();
            return JToken.Parse(json);
        }
        [HttpGet]
        public JToken Get(int id)
        {
            Product product = db.Products.Where(p => p.CategoryId == id).FirstOrDefault();

            return JToken.Parse(product.ToString());
        }
    }
}
