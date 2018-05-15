using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
                double rows =Math.Truncate( w / 1.2);
                double avalableHeight = Math.Truncate((h - 1) / 0.7);
                double result = rows * avalableHeight - 3;
                Console.WriteLine(result);            
        }
    }
}
