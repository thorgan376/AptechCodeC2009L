using System;

namespace EpcProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonaci fibonaci = new Fibonaci()
            {
                N = 1000
            };
            fibonaci.Calculate();
        }
    }
}
