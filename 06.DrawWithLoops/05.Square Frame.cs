using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            //top
            Console.Write("+ ");
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

            //center
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("| ");
                for (int col = 1; col <=n-2; col++)
                {
                    Console.Write("- ");
                    
                }
                Console.Write("|");
                Console.WriteLine();
            }

            //bottom
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
