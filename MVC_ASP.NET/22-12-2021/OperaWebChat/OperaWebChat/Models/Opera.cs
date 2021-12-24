using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaWebChat.Models
{
    public class Opera
    {
        [Required]
        public int OperaID { get; set; }
        [StringLength(200)] //Title NVARCHAR(200)
        public string Title { get; set; }
        [CheckValidYear] //custom validation
        [Required]
        public int Year { get; set; }
        public string Composer { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }


    public class CheckValidYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            return (int)value >= 1958;
            /*
            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
            */
        }
        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne, 1598, by Corsi, Peri, and Rinuccini";
        }
    }
}