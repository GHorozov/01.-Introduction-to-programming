using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 1;

            for (int i = 1; i < n ; i++)
            {
                var next = b + c;
                b = c;
                c = next;
            }
            Console.WriteLine(c);
        }
    }
}
