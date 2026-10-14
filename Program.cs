using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rectangle.Definition());

            Rectangle[] myRectangleArray = new Rectangle[3];
            myRectangleArray[0] = new Rectangle(4, 3, new Point(2, 5), "blue");
            myRectangleArray[1] = new Rectangle();
            myRectangleArray[2] = new Rectangle(25, 10);

            for (int i = 0; i < myRectangleArray.Length; i++)
            {
                Console.WriteLine(myRectangleArray[i].CalculatePerimeter());
                Console.WriteLine(myRectangleArray[i].CalculateArea());
                Console.WriteLine(myRectangleArray[i].TopLeftCorner.X);
                Console.WriteLine(myRectangleArray[i].TopLeftCorner.Y);
                Console.WriteLine(myRectangleArray[i].DescribeSize());
            }
        }
    }
}