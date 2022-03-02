using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_C2009L_NguyenVanA.Models
{
    public class Category
    {
        
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage ="You must enter category's name"),]
        public string CategoryName { get; set; }        
        //circular object
        //virtual = overridable, lazy
        public virtual ICollection<Product> Products { get; set; }
        public Category() {
            Products = new HashSet<Product>();
        }
    }
}