using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n > n2)
            {
                Console.WriteLine("Greater number: {0}", n);
            }
            else 
            {
                Console.WriteLine("Greater number: {0}", n2);
            }
        }
    }
}
