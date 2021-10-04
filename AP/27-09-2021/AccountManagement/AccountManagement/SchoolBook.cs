using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    class SchoolBook:Book
    {
        //1 = new, 2 = old => NO !
        public BookType BookType { get; set; }
        public double TotalPrice { 
            get => BookType == BookType.New ? Amount * Price : Amount * Price * 0.5; 
        }
        public override void Input()
        {
            base.Input();
            /*
            string stringBookType = "";
            while(!stringBookType.Equals("old") && !stringBookType.Equals("new"))
            {
                Console.WriteLine("Enter bootype(please enter old or new):");
                stringBookType = Console.ReadLine() ?? "".ToLower();
                BookType = stringBookType.Equals("old") ? BookType.Old : BookType.New;
            }
            */
            int integerBookType = -1;
            while (integerBookType != 1 && integerBookType != 2)
            {
                Console.WriteLine("Enter bootype(please enter 1(old) or 2(new)):");
                integerBookType = Convert.ToInt32(Console.ReadLine());
                BookType = integerBookType == 1 ? BookType.Old : BookType.New;
            }
        }
    }
}
