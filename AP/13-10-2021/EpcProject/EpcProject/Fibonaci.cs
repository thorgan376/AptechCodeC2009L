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
            for(int i = 2; i <=N; i++)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
                Console.WriteLine($"f({i}) = {f2}");
            }
        }
           
    }
}
