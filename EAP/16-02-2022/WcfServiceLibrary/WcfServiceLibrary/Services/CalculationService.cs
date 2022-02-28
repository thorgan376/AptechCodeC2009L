using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary.Services
{
    public class CalculationService : ICalculationService
    {
        public int Add(int x, int y) => x + y;
       

        public int Divide(int x, int y)
        {
            if(y == 0) return 0;
            return x / y;
        }

        public int Multiply(int x, int y) => x * y;

        public int Sub(int x, int y) => x - y;
    }
}
