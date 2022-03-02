using EAP_C2009L_NguyenVanA.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EAP_C2009L_NguyenVanA.Controllers
{    
    public class JsonWSController : ApiController
    {
        private DataContext db = new DataContext();
        // GET api/values
        [HttpGet]
        public JToken Get()
        {
            return JToken.Parse(db.Products.ToString());
        }
        [HttpGet]
        public JToken Get(int id)
        {
            return JToken.Parse(db.Products
                .Where(product => product.ProductId == id)
                .FirstOrDefault()
                .ToString()
                );
        }
    }
}
