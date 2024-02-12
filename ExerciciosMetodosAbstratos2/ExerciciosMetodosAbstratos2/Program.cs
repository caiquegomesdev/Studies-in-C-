using ExerciciosMetodosAbstratos2.Entities;
using ExerciciosMetodosAbstratos2.Entities.Enums;

namespace ExerciciosMetodosAbstratos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int numShapes = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= numShapes; i++)
            {
                Console.WriteLine($"Shape#{i} data:");

                Shape shape;

                while (true)
                {
                    Console.Write("Rectangle or Circle (r/c)? ");
                    if (Enum.TryParse(Console.ReadLine(), true, out ShapeType shapeType))
                    {
                        if (shapeType == ShapeType.Rectangle)
                        {
                            shape = new Rectangle();
                            Console.Write("Color (Black/Blue/Red): ");
                            ((Rectangle)shape).Color = ReadColor();
                            Console.Write("Width: ");
                            ((Rectangle)shape).Width = double.Parse(Console.ReadLine());
                            Console.Write("Height: ");
                            ((Rectangle)shape).Height = double.Parse(Console.ReadLine());
                            break;
                        }
                        else if (shapeType == ShapeType.Circle)
                        {
                            shape = new Circle();
                            Console.Write("Color (Black/Blue/Red): ");
                            ((Circle)shape).Color = ReadColor();
                            Console.Write("Radius: ");
                            ((Circle)shape).Radius = double.Parse(Console.ReadLine());
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid shape type. Please enter 'r' for Rectangle or 'c' for Circle.");
                    }
                }

                shapes.Add(shape);
            }

            Console.WriteLine("\nSHAPE AREAS:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea().ToString("F2"));
            }
        }

        static Color ReadColor()
        {
            while (true)
            {
                Console.Write("Color (Black/Blue/Red): ");
                if (Enum.TryParse(Console.ReadLine().Trim(), true, out Color color))
                {
                    return color;
                }
                else
                {
                    Console.WriteLine("Invalid color. Please enter 'Black', 'Blue', or 'Red'.");
                }
            }
        }
    }
}

