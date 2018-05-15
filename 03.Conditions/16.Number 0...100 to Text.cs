using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayInt = new int[101];
            string[] arrayUpToNineteen = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] arrayTens = new string[] { ",", ",", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string hundred = "one hundred";
            if (n >= 0 && n <= 100)
            {
                if (n < 20)
                {
                    Console.WriteLine(arrayUpToNineteen[n]);
                }
                else if (n > 20 && n <= 99)
                {
                    Console.WriteLine(arrayTens[n / 10] + ((n % 10 > 0) ? " " + arrayUpToNineteen[n % 10] : ""));
                }
                else if (n == 100)
                {
                    Console.WriteLine(hundred);
                }
                else if (n == 20)
                {
                    Console.WriteLine("twenty");
                }
            }

            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
