using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EAP_C2009L.Models;

namespace EAP_C2009L.Controllers
{
    public class JsonWSController : ApiController
    {
        private DataContext db = new DataContext();
        [HttpGet]
        public JToken Get()
        {
            var products = db.Products;
            String xxx = products.ToString();
            return JToken.Parse(xxx);
        }
        [HttpGet]
        public JToken Get(int id)
        {
            Product product = db.Products.Where(p => p.CategoryId == id).FirstOrDefault();

            return JToken.Parse(product.ToString());
        }
    }
}
