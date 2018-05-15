using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int inc1 = 1;
            int inc2 = 2;
            int inc3 = 3;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == inc1)
                {
                    sum1 += num;
                    inc1 += 3;
                }
                
                if (i == inc2)
                {
                    sum2 += num;
                    inc2 += 3;
                }
               
                if (i == inc3)
                {
                    sum3 += num;
                    inc3 += 3;
                }
            }
                  
            Console.WriteLine("Sum1= {0}\nSum2= {1}\nSum3= {2}", sum1, sum2, sum3);
        }
    }
}
