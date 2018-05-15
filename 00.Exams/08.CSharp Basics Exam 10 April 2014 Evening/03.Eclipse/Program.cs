using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top line
            Console.WriteLine("{0}{1}{2}{1}{0}",new string(' ',1),new string('*',2*n-2),new string(' ',n+1));

            //middle
            for (int i = 0; i < n-2; i++)
            {
                if(i== n / 2 -1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",new string('/', 2 * n - 2),new string('-',n-1));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n - 1));
                }
            }

            //bottom line
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', 1), new string('*', 2 * n - 2), new string(' ', n + 1));
        }
    }
}
