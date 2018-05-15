using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= 2*n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }
            Console.WriteLine();
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}",evenSum);
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No, diff={0}",diff);
            }
        }
    }
}
