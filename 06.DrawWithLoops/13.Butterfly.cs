using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int star = n - 2;
            int dash = n - 2;
            for (int row = 1; row <= n - 2; row++)
            {

                if (row % 2 == 0)
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('-', dash));
                }
                else if (row % 2 == 1)
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('*', star));

                }
            }
           Console.WriteLine(new string(' ',n-1)+"@"+new string(' ',n-1));
            for (int row = 1; row <= n - 2; row++)
            {

                if (row % 2 == 0)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('-', dash));
                }
                else if (row % 2 == 1)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('*', star));

                }
            }
        }
    }
}
