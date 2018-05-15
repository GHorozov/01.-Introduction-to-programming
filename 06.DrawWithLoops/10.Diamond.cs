using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dash = (n - 1) / 2;
            int stars = 1;
            int mid = 1;

            if (n % 2 == 0)
            {
                dash = (n - 2) / 2;
                stars = 2;
                mid = 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', stars));

            if (n != 1 && n != 2)
            {
                dash -= 1;

                if (n % 2 == 0)
                {
                    stars -= 1;
                }

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', dash));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', mid));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', dash));

                    dash -= 1;
                    mid += 2;
                    Console.WriteLine();
                }

                dash = 1;
                mid -= 4;
                for (int i = 1; i < (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', dash));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', mid));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', dash));

                    dash += 1;
                    mid -= 2;
                    Console.WriteLine();
                }

                if (n % 2 == 0)
                {
                    stars += 1;
                }

                Console.WriteLine("{0}{1}{0}", new string('-', dash), new string('*', stars));
            }
        }
    }
}
