using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rectangle.Definition());

            Circle[] myCircleArray = new Circle[3];
            myCircleArray[0] = new Circle(3, new Point(1, 4), "green");
            myCircleArray[1] = new Circle();
            myCircleArray[2] = new Circle(6);

            Rectangle[] myRectangleArray = new Rectangle[3];
            myRectangleArray[0] = new Rectangle(4, 3, new Point(2, 5), "blue");
            myRectangleArray[1] = new Rectangle();
            myRectangleArray[2] = new Rectangle(25, 10);

            for (int i = 0; i < myCircleArray.Length; i++)
            {
                Console.WriteLine(myCircleArray[i]);
                Console.WriteLine(myCircleArray[i].DescribeSize());
            }

            for (int i = 0; i < myRectangleArray.Length; i++)
            {
                Console.WriteLine(myRectangleArray[i]);
                Console.WriteLine(myRectangleArray[i].DescribeSize());
            }
        }
    }
}