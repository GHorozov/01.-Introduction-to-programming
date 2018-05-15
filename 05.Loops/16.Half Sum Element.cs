using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
                sum += num;
            }
            sum = sum - maxNumber;
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes, sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(maxNumber - sum));
            }

        }
    }
}
