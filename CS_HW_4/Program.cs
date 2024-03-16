using System;
using ShapesBase;
using ShapeTypes;

namespace ShapeApp
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 10),
                new Circle(7),
                new Triangle(3, 4),
                new Trapezoid(3, 5, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
            }
        }
    }
}