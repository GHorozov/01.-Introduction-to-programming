using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxSequance = 0;
            int counter = 0;
            int start = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > start)
                {
                    counter += 1;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxSequance)
                {
                    maxSequance = counter;
                }

                start = num;
            }

            Console.WriteLine(maxSequance);
        }
    }
}
