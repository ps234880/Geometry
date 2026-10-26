using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Models
{
    public class Surface
    {
        private double _length;
        private double _width;
        public List<Shape> MyShapes;

        public Surface(double length, double width)
        {
            _length = length;
            _width = width;
            MyShapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            if (ShapeFitsInSurface(shape))
            {
                MyShapes.Add(shape);
                Console.WriteLine("This shape has been added");
            }
            else
            {
                Console.WriteLine("This shape is too large");
            }
        }

        public override string ToString()
        {
            string result = "";
            if (MyShapes.Count > 0)
            {
                MyShapes.Sort();
                foreach (Shape shape in MyShapes)
                {
                    result += shape.ToString() + "\n\n";
                }
            }
            return result;
        }

        private bool ShapeFitsInSurface(Shape shape)
        {
            if (shape is Rectangle rect)
            {
                if (rect.Length <= _length && rect.Width <= _width)
                    return true;
            }
            else if (shape is Circle circle)
            {
                if (circle.Radius <= _width / 2)
                    return true;
            }
            return false;
        }
    }
}
