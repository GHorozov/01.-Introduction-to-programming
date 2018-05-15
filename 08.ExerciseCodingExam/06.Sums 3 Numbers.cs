using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                Console.WriteLine(c);
            }
            else if (a + c == b)
            {
                Console.WriteLine(b);
            }
            else if (c + b == a)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
