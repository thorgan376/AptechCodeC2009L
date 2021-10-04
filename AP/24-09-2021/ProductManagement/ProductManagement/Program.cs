// See https://aka.ms/new-console-template for more information

using Com.Product;
using Com.Product.Computers;

namespace ProductManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Product productA = new Product(); //cannot init a object from abstract class
            Computer computerA = new Computer()
            {
                ProductId = "1",
                ProductName = "Gaming laptop",
                Producer = "Apple",
                Price =  111,
                Speed = 123,                
            };


        }
    }
}