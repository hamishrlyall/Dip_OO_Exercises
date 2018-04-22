using System;

namespace OO_Tasks_Inheritence {

    public abstract class Shape
    {

        //private string _name;
        //private string _colour;

        public string Colour { get; set; }

        public string Name { get; set; }

        public Shape(string Name, string Colour)
        {

        }

        public abstract double GetArea();


        public abstract double GetPerimeter();
    }

    public abstract class Quadrilateral : Shape
    {
        //private int _NumSides = 4;
        public int NumSides = 4;

        public Quadrilateral(string Name, string Colour) : base (Name, Colour)
        {

        }
    }

    public class Square : Quadrilateral
    {

        public double SideLength { get; set; }
        //private double _sideLength;

        public Square (string Name, string Colour, double SideLength) : base (Name, Colour)
        {

        }
        
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }

    }

    public class Rectangle : Quadrilateral
    {
        //private double _length;
        //private double _width;
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle (string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {

        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return (2 * Length) + (2 * Width);
        }

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public const double PI = 3.142;
        //private double _radius;

        public Circle(string Name, string Colour, double Radius) : base(Name, Colour)
        {

        }

        public override double GetArea()
        {
            return Radius * Radius * PI;
        }

        public double GetCircumference()
        {
            return 2 * Radius * PI;
        }

        public override double GetPerimeter()
        {
            return 2 * Radius * PI;
        }
    }
    
}