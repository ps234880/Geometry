using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Surface surface = new Surface(10, 7);
            surface.AddShape(new Rectangle(3, 3, new Point(0, 7), "red"));
            surface.AddShape(new Rectangle(3, 2, new Point(0, 4), "yellow"));
            surface.AddShape(new Rectangle(5, 2, new Point(0, 2), "green"));
            surface.AddShape(new Rectangle(2, 5, new Point(3, 7), "purple"));
            surface.AddShape(new Rectangle(5, 4, new Point(5, 7), "orange"));
            surface.AddShape(new Rectangle(5, 3, new Point(5, 3), "blue"));
            Console.WriteLine(surface);

            Surface surface2 = new Surface(10, 7);
            surface2.AddShape(new Rectangle(4, 3, new Point(0, 7), "red"));
            surface2.AddShape(new Circle(4, new Point(1.5, 1.5), "yellow"));
            surface2.AddShape(new Rectangle(9, 8, new Point(3, 2), "green"));
            surface2.AddShape(new Rectangle(4, 1, new Point(5, 7), "orange"));
            surface2.AddShape(new Circle(2, new Point(8, 5), "purple"));
            surface2.AddShape(new Rectangle(11, 3, new Point(5, 3), "blue"));
            Console.WriteLine(surface2);
            //Circle myCircle = new Circle(3, new Point(2, 5), "green");
            ////ShowInformation(myCircle);
            ////Console.WriteLine();

            //Rectangle myRectangle = new Rectangle(3, 4, new Point(-2, 6), "blue");
            ////ShowInformation(myRectangle);

            //Shape[] shapes = new Shape[3]; // this is not instantiate
            //shapes[0] = myCircle;
            //shapes[1] = myRectangle;
            //shapes[2] = new Circle(10, new Point(-1, -3), "crimson");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(shapes[i]);
            //    Console.WriteLine();
            //}

            //int integer1 = 3;
            //int integer2 = 3;
            //int? integer3 = 3;
            //int? integer4 = 3;

            //Console.WriteLine(integer1);
            //Console.WriteLine(integer2);
            //Console.WriteLine(integer3);
            //Console.WriteLine(integer4);

            //List<Circle> myCircles = new List<Circle>();
            //myCircles.Add(new Circle(3, new Point(1, 4), "green"));
            //myCircles.Add(new Circle());
            //myCircles.Add(new Circle(6));

            //Console.WriteLine($"There are now {myCircles.Count} circles");
            //Console.WriteLine("The radius of my second circle is: " + myCircles[1].Radius);

            //myCircles.RemoveAt(2);
            //Console.WriteLine($"There are now {myCircles.Count} circles");

            //foreach (Circle circle in myCircles)
            //{
            //    ShowInformation(circle);
            //    Console.WriteLine();
            //}
        }

        //public static void ShowInformation(Shape shape)
        //{
        //    Console.WriteLine(shape);
        //}
    }
}