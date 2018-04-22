using System;


namespace OO_Tasks_Interface {

    public interface IShapeProps
    {
        double GetArea();
        double GetPerimeter();

    }

    public interface ICircleProps
    {
        double GetArea();
        double GetCircumference();

    }

    public class Shape
    {
        //private string _name;
        //private string _colour;
        public string Colour { get; set; }
        public string Name { get; set; }

        public Shape(string Name, string Colour)
        {

        }

    }

    public class Quadrilateral : Shape
    {
        //private int _NumSides = 4;
        public int NumSides { get; set; }

        public Quadrilateral(string Name, string Colour) : base (Name, Colour)
        {

        }

    }

    public class Square : Quadrilateral
    {
        //private double _sideLength;
        private double SideLength { get; set; }

        public Square(string Name, string Colour, double SideLength) : base (Name, Colour)
        {

        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }
    }

    public class Rectangle : Quadrilateral
    {
        //private double _length;
        //private double _width;
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {

        }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * Length + 2 * Width;
        }
    }

    public class Circle : Shape
    {
        //private double _radius;
        public const double PI = 3.142;
        public double Radius { get; set; }

        public Circle(string Name, string Colour, double Radius) : base (Name, Colour)
        {

        }

        public double GetArea()
        {
            return Radius * Radius * PI;
        }

        public double GetCircumference()
        {
            return 2 * Radius * PI;
        }

        public double GetPerimeter()
        {
            return 2 * Radius * PI;
        }
    }
}