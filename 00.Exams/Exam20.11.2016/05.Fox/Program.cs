using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;
            int dash = 2 * n - 1;
            //top
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}",new string('*',star),new string('-',dash));
                star += 1;
                dash -= 2;
            }

            //mid
            int starLeftRight = n / 2;
            int starMid = n;
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|",new string('*',starLeftRight),new string('*',starMid));
                starMid -= 2;
                starLeftRight += 1;
            }

            //bottom
            dash = 1;
            star = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', dash), new string('*', star));
                star -= 2;
                dash +=1;
            }
        }
    }
}
