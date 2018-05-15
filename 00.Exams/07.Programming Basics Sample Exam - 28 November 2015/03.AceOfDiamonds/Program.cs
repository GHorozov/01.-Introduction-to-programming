using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AceOfDiamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dash = n / 2 - 1;
            int monkey = 1;
            //top line
            Console.WriteLine("{0}",new string('*',n));

            //upper part
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",new string('-',dash),new string('@',monkey));
                dash -= 1;
                monkey += 2;
            }

            //middle line
            Console.WriteLine("*{0}*",new string('@',monkey));

            //down part
            dash = 1;
            monkey = monkey-2;
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",new string('-',dash),new string('@',monkey));
                dash += 1;
                monkey -= 2;
            }
            Console.WriteLine("{0}", new string('*', n));

        }
    }
}
