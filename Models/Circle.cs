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
    }
}
