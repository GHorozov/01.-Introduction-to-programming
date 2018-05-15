using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //First line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            //In the middle
            for (int row = 1; row <= n - 2; row++)
            {
                //left
                Console.Write("*");
                for (int i = 1; i <= ((n * 2) - 2); i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                //Nose hook :)
                if (n % 2 == 0)
                {
                    if (row == (n / 2) - 1)
                    {
                        Console.Write(new string('|', n));
                    }

                    else
                    {
                        Console.Write(new string(' ', n));
                    }
                }
                else
                {
                    if (row == (n / 2))
                    {
                        Console.Write(new string('|', n));
                    }

                    else
                    {
                        Console.Write(new string(' ', n));
                    }
                }
                //right
                Console.Write("*");
                for (int i = 1; i <= ((n * 2) - 2); i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            //Last line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

        }
    }
}
