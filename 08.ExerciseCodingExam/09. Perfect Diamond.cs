using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }

            int blank = n - 2;
            //top
            Console.WriteLine("{0}*{0}",new string(' ',n-1));
            for (int i = 1; i < n-1; i++)
            {
                Console.Write(new string(' ',blank));
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-*");
                }   
                Console.WriteLine(new string(' ', blank));

                blank -= 1;
            }
            
            //bottom
            blank = 0;
            for (int i = n - 1; i > 0 ; i--)
            {
                Console.Write("{0}", new string(' ', blank ));
                Console.Write("*");
                for (int j = i ; j > 0 ; j--)
                {
                    Console.Write("-");
                    Console.Write("*");
                }
                
                Console.WriteLine("{0}", new string(' ', blank));

                blank += 1;
            }
            Console.WriteLine("{0}*{0}", new string(' ', blank));



            //II-na4in vzet ot foruma na SoftUni
            //string line = "-*";
            //int n = int.Parse(Console.ReadLine());
            //if (n > 1 && n <= 1000)
            //{
            //    Console.Write(new string(' ', n - 1));
            //    Console.WriteLine("*");
            //    for (int i = 2; i <= n; i++)
            //    {
            //        Console.Write(new string(' ', n - i));
            //        Console.Write("*");
            //        Console.WriteLine(string.Concat(Enumerable.Repeat(line, i - 1)));
            //    }
            //    for (int i = n - 1; i > 1; i--)
            //    {
            //        Console.Write(new string(' ', n - i));
            //        Console.Write("*");
            //        Console.WriteLine(string.Concat(Enumerable.Repeat(line, i - 1)));
            //    }
            //    Console.Write(new string(' ', n - 1));
            //    Console.WriteLine("*");
            //}
        }
    }
}
