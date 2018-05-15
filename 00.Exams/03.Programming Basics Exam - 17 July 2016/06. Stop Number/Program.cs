using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int currentNum = 0;
            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    currentNum = i;
                    if (currentNum == s)
                    {
                        break;
                    }
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
        }
    }
}
