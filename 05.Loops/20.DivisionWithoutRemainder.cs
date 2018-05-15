using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double sumP1 = 0;
            double sumP2 = 0;
            double sumP3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    sumP1 += 1;
                    p1 = (sumP1 / n) * 100;
                }
                if (num % 3 == 0)
                {
                    sumP2 += 1;
                    p2 = (sumP2 / n) * 100;
                }
                if (num % 4 == 0)
                {
                    sumP3 += 1;
                    p3 = (sumP3 / n) * 100;
                }
            }
            Console.WriteLine("\n{0:f2}%\n{1:f2}%\n{2:f2}%\n",p1,p2,p3);
        }
    }
}
