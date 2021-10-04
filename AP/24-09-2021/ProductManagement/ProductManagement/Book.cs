using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Product.Books
{
    public class Book : Product //: = extends, inherits, implements
    {
        /*
        private float speed; //variable = field
        public float Speed { get => speed; set { 
            speed = value;
        } 
        }
        */

        public BookType Type { get; set; }
        public string Publisher { get; set; } //Producer is "function"

        public override void Display()
        {
            //base = super
            Console.WriteLine($"id: {base.ProductId}, " +
                $"product's name: {base.ProductName}" +
                $"product's price: {base.Price}" +
                $"year: {base.Year}" +
                $"speed: {this.Type}" +
                $"Producer: {this.Publisher}"
                );
        }

        public override void Input()
        {
            try
            {
                //tu viet

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }        
    }
}
