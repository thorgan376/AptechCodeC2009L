namespace Exam1
{
    public class Test
    {
        public static void Main(string[] args)
        {
            ShapeCollections shapeCollections = new ShapeCollections();
            string choice = "";
            while(!choice.Equals("Quit"))
            {
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine() ?? "";
                switch(choice)
                {
                    case "Circle":
                        shapeCollections.AddCircle();
                        break;
                    case "Rectangle":
                        shapeCollections.AddRectangle();
                        break;
                    case "Show":
                        foreach(Shape shape in shapeCollections.Shapes)
                        {
                            shape.ShowArea();
                        }
                        break;
                }
            }
        }
    }
}
