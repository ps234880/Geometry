using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Circle
    {
        public double Radius;
        public double CenterX;
        public double CenterY;
        public string Color;

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public Circle(double radius, double centerX, double centerY, string color)
        {
            this.Radius = radius;
            this.CenterX = centerX;
            this.CenterY = centerY;
            this.Color = color;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.CenterX = 0;
            this.CenterY = 0;
            this.Color = "white";
        }

        public Circle()
        {
            this.Radius = 1;
            this.CenterX = 0;
            this.CenterY = 0;
            this.Color = "white";
        }

        public static string Definition()
        {
            return "A circle is a collection of points that all have the same distance to a center point.";
        }
    }
}
