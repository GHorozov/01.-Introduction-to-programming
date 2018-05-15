using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double evenSum = 0.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;
            double oddSum = 0.0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());


                if (i % 2 == 1)
                {

                    if (num < oddMin)
                    {
                        oddMin = num;

                    }
                    if(num > oddMax)
                    {
                        oddMax = num;
                    }

                    oddSum += num;
                }
                if (i % 2 == 0)
                {

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;

                    }
                    evenSum += num;
                }

            }
            if (n == 0)
            {
                Console.WriteLine("OddSum={0}\nOddMin={1}\nOddMax={2}\nEvenSum={3}\nEvenMin={4}\nEvenMax={5}", oddSum, "No", "No", evenSum, "No", "No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum={0}\nOddMin={1}\nOddMax={2}\nEvenSum={3}\nEvenMin={4}\nEvenMax={5}", oddSum, oddMin, oddMax, evenSum, "No", "No");
            }
            else
            {
                Console.WriteLine("OddSum={0}\nOddMin={1}\nOddMax={2}\nEvenSum={3}\nEvenMin={4}\nEvenMax={5}", oddSum, oddMin, oddMax,evenSum,evenMin,evenMax);
            }
        }
    }
}
