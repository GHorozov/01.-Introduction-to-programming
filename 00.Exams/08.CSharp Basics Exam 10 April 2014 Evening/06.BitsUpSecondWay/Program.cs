using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BitsUpSecondWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int bit = 8;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                int mask = 1;
                int k = 2;
                if (i==0)
                {
                    num = num | (mask >> 1);
                    num = num | (mask >> (1 + step));

                    while(1+k*step <= bit)
                    {
                        num = num | (mask>> (1+k*step));
                        k++;
                    }
                }
                else
                {
                    while (1 + k * step <= bit)
                    {
                        num = num | (mask >> (1 + k * step));
                        k++;
                    }
                }

            }
        }
    }
}
