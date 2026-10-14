using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    internal class Circle
    {
        private const double LimitValueForBigShape = 100.0;
        private double _radius;
        private Point _center;
        private string _color;

        public double Radius   // property
        {
            get { return _radius; }   // get method
            set { _radius = value; }  // set method
        }

        public Point Center
        {
            get => _center; // different way
            set => _center = value;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public string DescribeSize()
        {
            if (CalculateArea() > LimitValueForBigShape)
                return "I am big!!!";
            else
                return "I am small!!!";
        }

        public Circle(double radius, Point center, string color)
        {
            _radius = radius;
            _center = center;
            _color = color;
        }

        public Circle(double radius) : this(radius, new Point(), "white")
        {
        }

        public Circle() : this(1)
        {
        }

        public static string Definition()
        {
            return "A circle is a collection of points that all have the same distance to a center point.";
        }
    }
}
