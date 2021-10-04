using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.models
{
    public class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        //constructor = not necessary !
        public override string ToString() => $"x: {X}, y: {Y}";
    }
}
