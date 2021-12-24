using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Product
    {
        [Display(Name = "Product's name")]
        public String ProductName { get; set; }
        [Display(Name = "Year of production")]
        public uint Year { get; set; }
        [Display(Name = "Product's price")]
        public double Price { get; set; }
        public String Description { get; set; }
    }
}