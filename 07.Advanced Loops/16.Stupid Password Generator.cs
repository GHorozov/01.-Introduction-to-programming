using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= n; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <= n; secondDigit++)
                {
                    for (char firstChar = 'a'; firstChar < 'a' + L; firstChar++)
                    {
                        for (char secondChar = 'a'; secondChar < 'a' + L; secondChar++)
                        {
                            for (int thirthDigit = Math.Max(firstDigit, secondDigit)+1; thirthDigit <= n; thirthDigit++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, firstChar, secondChar, thirthDigit);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
