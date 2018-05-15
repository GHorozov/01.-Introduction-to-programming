using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum2 += num;
            }

            if (sum == sum2)
            {
                Console.WriteLine("Yes,sum = {0}",sum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}",Math.Abs(sum-sum2));
            }
        }
    }
}
