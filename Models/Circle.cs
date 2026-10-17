using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Circle : Shape
    {
        private double _radius;
        private Point _center;

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

        public Circle(double radius, Point center, string color) : base(color)
        {
            _radius = radius;
            _center = center;
        }

        public Circle(double radius) : this(radius, new Point(), DefaultColor)
        {
        }

        public Circle() : this(1)
        {
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public static string Definition()
        {
            return "A circle is a collection of points that all have the same distance to a center point.";
        }

        public override string ToString()
        {
            return base.ToString() + "\nRadius: " + _radius + "\nCenter: " +
            _center.ToString();
        }
    }
}
