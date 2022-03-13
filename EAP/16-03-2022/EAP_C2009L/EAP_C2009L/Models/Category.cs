using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_C2009L.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "You must enter the category's name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}