using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());      
            int evenNumber = 0;
            int oddNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNumber += num;
                }
                else
                {
                    oddNumber += num;
                }
            }

            if (evenNumber == oddNumber)
            {
                Console.WriteLine("Yes,sum = {0}", evenNumber);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(evenNumber - oddNumber ));
            }
        }
    }
}
