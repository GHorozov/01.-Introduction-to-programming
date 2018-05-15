using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(squareSide * squareSide, 3));
                    break;
                case "rectangle":
                    double rectangleSideOne = double.Parse(Console.ReadLine());
                    double rectangleSideTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(rectangleSideOne * rectangleSideTwo, 3));
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    Console.WriteLine((Math.Round(Math.PI * (Math.Pow(circleRadius, 2)), 3)));
                    break;
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(((triangleSide * triangleHeight) / 2), 3));
                    break;
                default:
                    Console.WriteLine("Incorect input.");
                    break;
            }
        }
    }
}
