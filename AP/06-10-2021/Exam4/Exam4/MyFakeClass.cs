using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    internal class MyFakeClass : IMyInterface
    {
        public void DoSomething(string y)
        {
            Console.WriteLine(y);
        }
    }
}
