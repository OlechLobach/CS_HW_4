using System;
using ShapesBase;

namespace ShapeTypes
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class Trapezoid : Shape
    {
        public double TopBase { get; }
        public double BottomBase { get; }
        public double Height { get; }

        public Trapezoid(double topBase, double bottomBase, double height)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (TopBase + BottomBase) * Height;
        }
    }
}