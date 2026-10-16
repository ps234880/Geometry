using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Rectangle
    {
        private const double LimitValueForBigShape = 100.0;
        private double _length;
        private double _width;
        private Point _topLeftCorner;
        private string _color;

        public double Length
        {
            get => _length;
            set => _length = value;
        }
        public double Width
        {
            get => _width;
            set => _width = value;
        }
        public Point TopLeftCorner
        {
            get => _topLeftCorner;
            set => _topLeftCorner = value;
        }
        public string Color
        {
            get => _color;
            set => _color = value;
        }
        public Rectangle(double length, double width, Point topLeftCorner, string color)
        {
            this._length = length;
            this._width = width;
            this._topLeftCorner = topLeftCorner;
            this._color = color;
        }
        public Rectangle(double length, double width) : this(length, width, new Point(), "white")
        {
        }
        public Rectangle(): this (2, 1)
        {
        }
     
       
        public string DescribeSize()
        {
            if (CalculateArea() > LimitValueForBigShape)
                return "I am big!!!";
            else
                return "I am small!!!";
        }

        public double CalculateArea()
        {
            return _length * _width;
        }
        public double CalculatePerimeter()
        {
            return 2 * _length + 2 * _width;
        }
        public static string Definition()
        {
            return "A rectangle is a quadrilateral with four right angles";
        }
    }
}
