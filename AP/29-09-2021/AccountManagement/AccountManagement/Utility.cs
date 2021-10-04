using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    class Utility
    {
        public static DateTime ToDateTime(string? inputString) {
            //25/12/2020
            string[] arrayOfItems = (inputString ?? "").Split("/");
            /*
            if (arrayOfItems.Length != 3)
            {
                return DateTime.Now;
            }
            int year = Convert.ToInt32(arrayOfItems[2]);
            int month = Convert.ToInt32(arrayOfItems[1]);
            int day = Convert.ToInt32(arrayOfItems[0]);
            return new DateTime(year, month, day);
            */
            return arrayOfItems.Length == 3 ? 
                new DateTime(
                    Convert.ToInt32(arrayOfItems[2]), 
                    Convert.ToInt32(arrayOfItems[1]), 
                    Convert.ToInt32(arrayOfItems[0]))
                : DateTime.Now;
        }
    }
}
