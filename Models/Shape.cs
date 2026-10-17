using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Geometry.Models
{
    public abstract class Shape
    {
        protected const double LimitValueForBigShape = 100.0;
        protected const string DefaultColor = "white";
        protected string _color;

        public string Color 
        {
            get => _color;
            set => _color = value;
        }

        public Shape(string color)
        {
            this._color = color;
        }

        public Shape() : this (DefaultColor)
        {
            
        }
     
        public string DescribeSize()
        {
            if (CalculateArea() > LimitValueForBigShape)
                return "I am big!!!";
            else
                return "I am small!!!";
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public static string Definition()
        {
            return "A shape is a collection of points.";
        }

        public override string ToString()
        {
            return "Color: " + _color + "\nPerimeter: " + CalculatePerimeter() +
            "\nArea: " + CalculateArea();
        }
    }
}
