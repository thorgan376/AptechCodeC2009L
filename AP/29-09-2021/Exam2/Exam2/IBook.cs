using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    interface IBook
    { 
        public string this[int i] {get; set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public void Show();

    }
}
