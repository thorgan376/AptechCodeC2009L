using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    class Book
    {
        public string Code {  get; set; }
        public DateTime InputDate {  get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Publisher { get; set; }
        public virtual void Input()
        {
            Console.WriteLine("Enter code: ");
            Code = Console.ReadLine()?? "".ToLower();

            Console.WriteLine("Enter input date(dd/mm/yyyy): ");
            string stringInputDate = Console.ReadLine() ?? "".ToLower();
            InputDate = Utility.ToDateTime(stringInputDate);

            //input date ?
            Console.WriteLine("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter amount:");
            Amount = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
