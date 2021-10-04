using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    class ReferenceBook: Book
    {
        public float Tax { get; set; }
        public double TotalPrice
        {
            get => Amount * Price * (Tax + 1);
        }
    }
}
