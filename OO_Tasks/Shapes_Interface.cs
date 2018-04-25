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
        private string _name;
        private string _colour;
        public string Colour { get; set; }
        public string Name { get; set; }

        public Shape(string Name, string Colour)
        {
            _name = Name;
            _colour = Colour;
        }

    }

    public class Quadrilateral : Shape
    {
        private int _numSides = 4;
        public int NumSides { get; set; }

        public Quadrilateral(string Name, string Colour) : base (Name, Colour)
        {

            _numSides = NumSides;
        }

    }

    public class Square : Quadrilateral
    {
        private double _sideLength;
        private double SideLength { get; set; }

        public Square(string Name, string Colour, double SideLength) : base (Name, Colour)
        {
            _sideLength = SideLength;
        }

        public double GetArea()
        {
            return _sideLength * _sideLength;
        }

        public double GetPerimeter()
        {
            return 4 * _sideLength;
        }
    }

    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {
            _length = Length;
            _width = Width;
        }

        public double GetArea()
        {
            return _length * _width;
        }

        public double GetPerimeter()
        {
            return 2 * _length + 2 * _width;
        }
    }

    public class Circle : Shape
    {
        private double _radius;
        public const double PI = 3.142;
        public double Radius { get; set; }

        public Circle(string Name, string Colour, double Radius) : base (Name, Colour)
        {
            _radius = Radius;
        }

        public double GetArea()
        {
            return _radius * _radius * PI;
        }

        public double GetCircumference()
        {
            return 2 * _radius * PI;
        }

        public double GetPerimeter()
        {
            return 2 * _radius * PI;
        }
    }
}