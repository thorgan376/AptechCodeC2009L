using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Product.Computers
{
    public class Computer : Product //: = extends, inherits, implements
    {
        /*
        private float speed; //variable = field
        public float Speed { get => speed; set { 
            speed = value;
        } 
        }
        */

        public float Speed {  get; set; }
        public string Producer {  get; set; } //Producer is "function"

        public override void Display()
        {
            //base = super
            Console.WriteLine($"id: {base.ProductId}, " +
                $"product's name: {base.ProductName}"+
                $"product's price: {base.Price}" +
                $"year: {base.Year}" +
                $"speed: {this.Speed}" +
                $"Producer: {this.Producer}"
                );
        }

        public override void Input()
        {
            try
            {
                Console.WriteLine($"enter product's id: ");
                ProductId = Console.ReadLine() ?? "";

                Console.WriteLine($"enter product's name: ");
                ProductName = Console.ReadLine() ?? "";

                Console.WriteLine($"enter product's price: ");
                Price = (float)Convert.ToDouble(Console.ReadLine()); //explicit casting
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public override void DoSomething()
        {
            //not the same with Java
            //can only override "virtual" methods
            //protected override(child) => protected virtual(parent)
            //public override(child) => public virtual(parent)
        }
    }
}
