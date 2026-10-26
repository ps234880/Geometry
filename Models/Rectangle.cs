using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Geometry.Models
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        private Point _topLeftCorner;

        public double Length
        {
            get => _length;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The length must be positive.");
                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The width must be positive.");
                _width = value;
            }
        }

        public Point TopLeftCorner
        {
            get => _topLeftCorner;
            set => _topLeftCorner = value;
        }

        public Rectangle(double length, double width, Point topLeftCorner, string color) : base(color)
        {
            this.Length = length;
            this.Width = width;
            this._topLeftCorner = topLeftCorner;
        }

        public Rectangle(double length, double width) : this(length, width, new Point(), DefaultColor)
        {
        }

        public Rectangle(): this (2, 1)
        {
        }
     
        public override double CalculateArea()
        {
            return _length * _width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * _length + 2 * _width;
        }

        public static string Definition()
        {
            return "A rectangle is a quadrilateral with four right angles";
        }

        public override string ToString()
        {
            return base.ToString() + "\nLength: " + _length + "\nWidth: " +
            _width + "\nCorner: " + _topLeftCorner.ToString();
        }
    }
}
