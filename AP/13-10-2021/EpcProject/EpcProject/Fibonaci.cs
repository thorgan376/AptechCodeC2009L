using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpcProject
{
    public class Fibonaci
    {
        private int n;
        public int N { get => n; 
            set {
                if (value < 2) {
                    throw new Exception("N must be >= 2");
                }
                n = value;
            } 
        }
        public void Calculate()
        {
            double f0 = 1;
            double f1 = 1;
            double f2;
            double sum = f0 + f1;
            for(int i = 2; i <=N; i++)
            {
                f2 = f0 + f1;
                sum += f2;
                f0 = f1;
                f1 = f2;
                Console.WriteLine($"f({i}) = {f2}");
            }
            Console.WriteLine($"sum = {sum / (75765 * 1000)}");
            //double x = (sum / (75765 * 1000))/ 6000000000000000000000.0;
            //Console.WriteLine(x * 100);
        }
           
    }
}
