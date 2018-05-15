using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top
            var starsCount = 1;
            if (n % 2 == 0)
            {
                starsCount++;
            }

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                var dashCount = (n - starsCount) / 2;
                Console.Write(new string('-', dashCount)); 
                Console.Write(new string('*', starsCount));
                Console.WriteLine(new string('-', dashCount));

                starsCount += 2;
                dashCount -= 1;
            }

            //bottom
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.WriteLine(new string('|', 1));
            }
        }

    }
}
