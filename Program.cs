using Geometry.Models;
using System;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myAllArgsCircle = new Circle(3, 1, 4, "green");
            Console.WriteLine(myAllArgsCircle.CalculatePerimeter());
            Console.WriteLine(myAllArgsCircle.CalculateArea());

            Circle myDefaultCircle = new Circle();
            Console.WriteLine(myDefaultCircle.CalculatePerimeter());
            Console.WriteLine(myDefaultCircle.CalculateArea());

            Circle myRadiusCircle = new Circle(6);
            Console.WriteLine(myRadiusCircle.CalculatePerimeter());
            Console.WriteLine(myRadiusCircle.CalculateArea());
        }
    }
}