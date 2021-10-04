using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class ShapeCollections
    {
        private List<Shape> shapes= new List<Shape>();
        public List<Shape> Shapes { get => shapes};
        public void AddCircle()
        {
            try
            {
                Console.WriteLine("Enter radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Circle circle= new Circle() { 
                    Radius= radius,
                };
                shapes.Add(circle);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void AddRectangle()
        {
            try
            {
                Console.WriteLine("Enter width: ");
                double witdh = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Rectangle rectangle = new Rectangle()
                {
                    Width = witdh,
                    Length = length,
                };
                shapes.Add(rectangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ShowAllShapes()
        {
            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
