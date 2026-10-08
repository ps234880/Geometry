using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle[] myCircleArray = new Circle[3];
            myCircleArray[0] = new Circle(3, 1, 4, "green");
            myCircleArray[1] = new Circle();
            myCircleArray[2] = new Circle(6);

            for (int i = 0; i < myCircleArray.Length; i++)
            {
                Console.WriteLine(myCircleArray[i].CalculatePerimeter());
                Console.WriteLine(myCircleArray[i].CalculateArea());
            }
        }
    }
}