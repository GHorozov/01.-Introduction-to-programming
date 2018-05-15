using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = (n / 100) + ((n / 10)%10);
            int cols = (n / 100) + (n % 10);
            int firstDigit = n / 100;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = n % 10;
            int result = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int i = 0; i < cols; i++)
                {
                    if (n % 3 == 0)
                    {
                        result = n - (secondDigit);
                    }
                    if (n % 5 == 0)
                    {                 
                        result = n - (firstDigit);
                    }
                    if(!(n % 3 == 0)&& !(n % 5 == 0))
                    {
                        result = n + (thirdDigit);                 
                    }
                    Console.Write("{0} ", result);
                    n =result;
                }
               
                Console.WriteLine();
            }
        }
    }
}
