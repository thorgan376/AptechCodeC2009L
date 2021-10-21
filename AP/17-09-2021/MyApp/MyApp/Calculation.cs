using MyApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Calculation
    {
        public static int Sum2Numbers(int x, int? y) { 
            return x + (y ?? 0);
        }
        public static int Minus2Number(int x, int? y) {
            if (x < 0)
            {
                Console.WriteLine("x phai lon hon 0");
                return 0;
            }
            return x - (y ?? 1);
                }
        public static double Multiply2Numbers(double x, double y) =>  x * y;        
        public static void DoSomeThing(dynamic x) { 
            Console.WriteLine($"x = {x}");
        }
        //overloading
        public static int Substract(int x) => x;
        public static int Substract(int x, int y) => x- y;
        public static int Substract(int x, int y, int z) => x - y - z;
        public static int RandomInt(int min, int max) => (new Random()).Next(min, max);
        public static void GeneratePoints() {
            List<Point> points = new List<Point>();            
            for (int i = 0; i < 1_000_000_0000; i++)
            {
                //Builder Pattern
                Point point = new Point()
                {
                    X = Calculation.RandomInt(1, 100),
                    Y = Calculation.RandomInt(1, 100),
                };
                points.Add(point);
                //Console.WriteLine($"point = {point.ToString()}");
            }
        }
    }
    
}
