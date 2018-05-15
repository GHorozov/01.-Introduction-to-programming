using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();

            double result = 00;
            if (N2 == 0)
            {
                Console.WriteLine("Ypu cannot devide by {0}", N2);
            }
            else if (operator1 == "+")
            {
                Console.Write("{0} + {1} = {2} - ", N1, N2, N1 + N2);
                if ((N1 + N2) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            else if (operator1 == "-")
            {
                Console.Write("{0} - {1} = {2} - ", N1, N2, N1 - N2);
                if ((N1 - N2) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            else if (operator1 == "*")
            {
                Console.Write("{0} * {1} = {2} - ", N1, N2, N1 * N2);
                if ((N1 * N2) % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }
            else if (N2 != 0 && operator1 == "/")
            {
                result = (double)N1 / (double)N2;
                Console.WriteLine("{0} / {1} = {2:f2}", N1, N2,result );
            }
            else if (N2 != 0 && operator1 == "%")
            {
                Console.WriteLine("{0} % {1} = {2}", N1, N2, N1 % N2);
            }   
            else
            {
                Console.WriteLine("Invalid input.Try again!");
            }
        }
    }
}
