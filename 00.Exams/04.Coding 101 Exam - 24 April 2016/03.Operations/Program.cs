using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string state = "";
            if (op == "+" || op == "-" || op == "*")
            {
                if (op == "+")
                {
                    result = n + n1;
                    if (result % 2 == 0)
                    {
                        state = "even";
                    }
                    if (result % 2 == 1)
                    {
                        state = "odd";
                    }
                    Console.WriteLine("{0} + {1} = {2} - {3}", n, n1, result, state);
                }
                if (op == "-")
                {
                    result = n - n1;
                    if (result % 2 == 0)
                    {
                        state = "even";
                    }
                    if (result % 2 == 1)
                    {
                        state = "odd";
                    }
                    Console.WriteLine("{0} - {1} = {2} - {3}", n, n1, result, state);
                }
                if (op == "*")
                {
                    result = n * n1;
                    if (result % 2 == 0)
                    {
                        state = "even";
                    }
                    if (result % 2 == 1)
                    {
                        state = "odd";
                    }
                    Console.WriteLine("{0} * {1} = {2} - {3}", n, n1, result, state);
                }
            }
            else if (op == "/")
            {
                if (n1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n);
                }
                else
                {
                    result = (double)n / n1;
                    Console.WriteLine("{0} / {1} = {2:f2}",n, n1, result);
                }

            }
            else if (op == "%")
            {
                if (n1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n);
                }
                else
                {
                    result = (double)n % n1;
                    Console.WriteLine("{0} % {1} = {2}", n, n1, result);
                }
            }
        }
    }
}
