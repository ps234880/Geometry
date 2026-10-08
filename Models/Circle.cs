using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Geometry.Models
{
    public class Circle
    {
        private const double LimitValueForBigShape = 100.0;
        private double _radius;
        private double _centerX;
        private double _centerY;
        private string _color;

        public double Radius   // property
        {
            get { return _radius; }   // get method
            set { _radius = value; }  // set method 
        }

        public double CenterX
        {
            get { return _centerX; }
            set { _centerX = value; }
        }

        public double CenterY
        {
            get { return _centerY; }
            set { _centerY = value; }
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

        public Circle(double radius, double centerX, double centerY, string color)
        {
            this._radius = radius;
            this._centerX = centerX;
            this._centerX = centerY;
            this._color = color;
        }

        public Circle(double radius) : this(radius, 0, 0, "white")
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
