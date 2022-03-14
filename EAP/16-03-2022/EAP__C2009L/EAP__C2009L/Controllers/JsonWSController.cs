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
        //api/JsonWS
        public JToken Get()
        {
            List<Product> products = db.Products.ToList();
            return JToken.FromObject(products.Select(product => new {
                Name = product.Name,
                ProductId = product.ProductId,
                Price = product.Price,
                Quantity = product.Quantity
            }));
        }
        public JToken Get(int id)
        {
            Product product = db.Products
            .Where(p => p.CategoryId == id)
            .FirstOrDefault();

            return JToken.FromObject(new {
                Name = product.Name,
                ProductId = product.ProductId,
                Price = product.Price,
                Quantity = product.Quantity
            });
        }
    }
}
