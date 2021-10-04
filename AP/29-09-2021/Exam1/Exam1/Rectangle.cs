using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Rectangle:Shape
    {
        private double width, length;
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
        public override void ShowArea()
        {
            
        }
    }
}
