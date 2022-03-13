using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EAP_C2009L.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid float Number")]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Category Category { get; set; }

    }
}