using System;

namespace OO_Tasks_Interface {

    public interface IShapeProps
    {
        /*public double GetArea()
        {
            return 0;
        }

        public double GetPerimeter()
        {
            return 0;
        }*/
    }

    public interface ICircleProps
    {
        /*public double GetArea()
        {
            return 0;
        }

        public double GetCircumference()
        {
            return 0;
        }*/
    }

    public class Shape
    {

        private string _name;

        private string _colour;

        public Shape(string Name, string Colour)
        {

        }

        public string Colour()
        {
            return _colour;
        }
        
        public string Name()
        {
            return _name;
        }


    }

    public class Quadrilateral : Shape
    {
        private int _NumSides = 4;

        public Quadrilateral(string Name, string Colour) : base (Name, Colour)
        {

        }

        public int NumSides()
        {
            return _NumSides;
        }
    }

    public class Square : Quadrilateral
    {
        private double _sideLength;

        public Square(string Name, string Colour, double sideLength) : base (Name, Colour)
        {

        }

        public double GetArea()
        {
            return 0;
        }

        public double GetPerimeter()
        {
            return 0;
        }
    }

    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;

        public Rectangle(string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {

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

        public Circle(string Name, string Colour, double Radius) : base (Name, Colour)
        {

        }

        public double Radius()
        {
            return _radius;
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