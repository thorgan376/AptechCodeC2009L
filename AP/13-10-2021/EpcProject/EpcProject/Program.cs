using System;

namespace EpcProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonaci fibonaci = new Fibonaci()
            {
                N = 64
            };
            fibonaci.Calculate();
        }
    }
}
