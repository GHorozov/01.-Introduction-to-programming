﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("*");
            //Console.WriteLine("*" + "*");
            //Console.WriteLine("*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*" + "*" + "*" + "*");
            //Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*" + "*" + "*" + "*" + "*");


            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
