using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.FigureMyDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0 || n>=100)
            {
                Console.WriteLine("Invalid input.Try again!");
                return;
            }

            int blank = n-2;
            int blankMid = 1;
                
            Console.WriteLine("{0}|{0}",new string('.',n));
            for (int i = 1; i < n; i++)
            {
                Console.Write(".{0}*", new string(' ', blank));
                Console.Write("{0}",new string(' ',blankMid));
                Console.WriteLine("*{0}.", new string(' ', blank));

                blankMid += 2;
                blank -= 1;

            }
                     
            Console.WriteLine("-{0}G{0}-",new string('*',n-1));

            blank = 0;
            blankMid = 2*n-3;
            for (int i = 1; i < n; i++)
            {
                Console.Write(".{0}*",new string(' ',blank));
                Console.Write("{0}",new string(' ',blankMid));
                Console.WriteLine("*{0}.",new string(' ',blank));
                blank += 1;
                blankMid -=2;
            }

            Console.WriteLine("{0}|{0}", new string('.', n));

        }
    }
}
