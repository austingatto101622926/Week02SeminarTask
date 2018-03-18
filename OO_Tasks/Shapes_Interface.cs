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

    public class Shape {
        private string _name;
        private string _colour;

        public string Name { get { return _name; } set { _name = value; } }
        public string Colour { get { return _colour; } set { _colour = value; } }

        public Shape(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
    }

    public class Quadrilateral : Shape
    {
        private int _NumSides = 4;
        public int NumSides { get { return _NumSides; } private set { } }

        public Quadrilateral(string name, string colour) : base(name, colour) { }
    }

    public class Square : Quadrilateral,IShapeProps
    {
        private double _sideLength;

        public double GetArea()
        {
            return Math.Round(_sideLength * _sideLength, 2);
        }

        public  double GetPerimeter()
        {
            return Math.Round(4 * _sideLength, 2);
        }

        public Square(string name, string colour, double sideLength) : base(name, colour)
        {
            _sideLength = sideLength;
        }
    }

    public class Rectangle : Quadrilateral, IShapeProps
    {
        private double _length;
        private double _width;

        public double GetArea()
        {
            return Math.Round(_length * _width, 2);
        }

        public double GetPerimeter()
        {
            return Math.Round(2 * _length + 2 * _width, 2);
        }

        public Rectangle(string name, string colour, double length, double width) : base(name, colour)
        {
            _length = length;
            _width = width;
        }
    }

    public class Circle : Shape,ICircleProps{
        public const double PI = 3.142;
        private double _radius;

        public double Radius { get { return _radius; } set { _radius = value; } }

        public Circle(string name, string colour, double radius) : base(name, colour)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(_radius * _radius * PI, 2);
        }
        public double GetCircumference()
        {
            return Math.Round(_radius * 2 * PI, 2);
        }
    }
}