using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentPairValue=0;
            double prevPairValue = 0;
            double maxDiff = 1;
            double differens = 0;
               
            for (int i = 1; i <= n; i++)
            {
                currentPairValue = prevPairValue;
                int num = int.Parse(Console.ReadLine());
                int num1 = int.Parse(Console.ReadLine());

                prevPairValue = num + num1;               
                maxDiff =Math.Abs(currentPairValue - prevPairValue);
                if (maxDiff > differens && i>=2)
                {
                    differens = maxDiff;
                }             
            }
            if (differens == 0)
            {
                Console.WriteLine("Yes, value = {0}", prevPairValue);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", differens );
            }   
        }
    }
}
