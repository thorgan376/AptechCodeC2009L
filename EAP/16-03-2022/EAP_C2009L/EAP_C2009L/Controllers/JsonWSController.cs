using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EAP_C2009L.Models;
using Newtonsoft.Json.Linq;

namespace EAP_C2009L.Controllers
{
    public class JsonWSController : ApiController
    {
        private DataContext db = new DataContext();
        public JToken Get()
        {
            return "value1";
        }
        public JToken Get(int id)
        {
            return "value";
        }
    }
}
