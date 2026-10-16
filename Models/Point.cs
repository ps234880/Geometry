using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point() : this(0, 0)
        {
        }
        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }
    }
}