using System;

namespace OO_Tasks_Inheritence {

    public abstract class Shape
    {

        private string _name;
        private string _colour;

        public string Colour { get; set; }

        public string Name { get; set; }

        public Shape(string Name, string Colour)
        {
            _name = Name;
            _name = Name;
        }

        public abstract double GetArea();


        public abstract double GetPerimeter();
    }

    public abstract class Quadrilateral : Shape
    {
        private int _numSides = 4;
        public int NumSides = 4;

        public Quadrilateral(string Name, string Colour) : base (Name, Colour)
        {
            _numSides = NumSides;
        }
    }

    public class Square : Quadrilateral
    {

        public double SideLength { get; set; }
        private double _sideLength;

        public Square (string Name, string Colour, double SideLength) : base (Name, Colour)
        {
            _sideLength = SideLength;
        }
        
        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * _sideLength;
        }

    }

    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle (string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {
            _length = Length;
            _width = Width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }

        public override double GetPerimeter()
        {
            return (2 * _length) + (2 * _width);
        }

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public const double PI = 3.142;
        private double _radius;

        public Circle(string Name, string Colour, double Radius) : base(Name, Colour)
        {
            _radius = Radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * PI;
        }

        public double GetCircumference()
        {
            return 2 * PI * _radius;
        }

        public override double GetPerimeter()
        {
            return 2 * PI * _radius;
        }
    }
    
}