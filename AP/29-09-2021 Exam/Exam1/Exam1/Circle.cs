using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Circle : Shape
    {        
        private double radius;
        public double Radius { get => radius; set => radius = value; }
        public override void ShowArea() 
            => Console.WriteLine($"area = {Math.PI * radius * radius}");

    }
}
