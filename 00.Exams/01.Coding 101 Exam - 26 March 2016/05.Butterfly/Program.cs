using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dash = n - 2;
            int star = n - 2;
            int blank = n - 1;
            for (int i = 1; i <= n-2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(@"{0}\ /{0}",new string('-',dash));
                }
                else
                {
                    Console.Write(@"{0}\ /{0}", new string('*', star));

                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}@{0}",new string(' ',blank));
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(@"{0}/ \{0}", new string('-', dash));
                }
                else
                {
                    Console.Write(@"{0}/ \{0}", new string('*', star));

                }
                Console.WriteLine();
            }
        }
    }
}
