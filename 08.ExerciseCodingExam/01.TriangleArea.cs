using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCodingExam
{
    class triangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3=");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            int y3 = int.Parse(Console.ReadLine());

            y2 = y3;
            double a = Math.Max(x3,x2) - Math.Min(x3,x2);
            double h = Math.Max(y1,y2) - Math.Min(y1,y2);
            double S = (a * h) / 2;
            Console.WriteLine("Area of triangle is: " + S);

        }
    }
}
