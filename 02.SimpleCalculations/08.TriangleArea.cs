﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = a * height / 2;
            Console.WriteLine("Triangle area = {0}",Math.Round(area,2));
        }
    }
}
