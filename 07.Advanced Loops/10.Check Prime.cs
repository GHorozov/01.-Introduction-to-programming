using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if (n < 2)
            {
                isPrime = false;
                Console.WriteLine("Not Prime");
            }
            for (int devisor = 2; devisor < n; devisor++)
            {
                if (n% devisor == 0)
                {
                    isPrime = false;
                    Console.WriteLine("Not Prime");
                    break;
                }
            }
            if(isPrime==true)
            Console.WriteLine("Prime",isPrime);
        }
    }
}
