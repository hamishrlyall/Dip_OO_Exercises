﻿using System;

namespace OO_Tasks_Inheritence {

    public abstract class Shape
    {

        private string _name;
        private string _colour;

        public string Colour()
        {
            return _colour;
        }

        public string Name()
        {
            return _name;
        }

        public Shape(string Name, string Colour)
        {

        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }

        
    }

    public abstract class Quadrilateral : Shape
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

        public Square (string Name, string Colour, double SideLength) : base (Name, Colour)
        {

        }

        public double SideLength()
        {
            return _sideLength;
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

        public Rectangle (string Name, string Colour, double Length, double Width) : base(Name, Colour)
        {

        }

        public double Length()
        {
            return _length;
        }

        public double Width()
        {
            return _width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }

        public override double GetPerimeter()
        {
            return 2 * _length + 2 * _width;
        }

    }

    public class Circle : Shape
    {
        public const double PI = 3.142;
        private double _radius;

        public Circle(string Name, string Colour, double Radius) : base(Name, Colour)
        {

        }

        public double Radius()
        {
            return _radius;
        }

        public override double GetArea()
        {
            return _radius * _radius * PI;
        }

        public double GetCircumference()
        {
            return 2 * _radius * PI;
        }

        public override double GetPerimeter()
        {
            return 2 * _radius * PI;
        }
    }
    
}