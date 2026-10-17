using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(3, new Point(2, 5), "green");
            //ShowInformation(myCircle);
            //Console.WriteLine();

            Rectangle myRectangle = new Rectangle(3, 4, new Point(-2, 6), "blue");
            //ShowInformation(myRectangle);

            Shape[] shapes = new Shape[3]; // this is not instantiate
            shapes[0] = myCircle;
            shapes[1] = myRectangle;
            shapes[2] = new Circle(10, new Point(-1, -3), "crimson");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(shapes[i]);
                Console.WriteLine();
            }

            int integer1 = 3;
            int integer2 = 3;
            int? integer3 = 3;
            int? integer4 = 3;

            Console.WriteLine(integer1);
            Console.WriteLine(integer2);
            Console.WriteLine(integer3);
            Console.WriteLine(integer4);
        }

        public static void ShowInformation(Shape shape)
        {
            Console.WriteLine(shape);
        }
    }
}