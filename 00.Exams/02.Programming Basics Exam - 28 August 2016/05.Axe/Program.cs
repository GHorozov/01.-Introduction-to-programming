using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dash = 3 * n;
            int dashMid = 0;
            int dashRight = 2 * n - 2;
            int star = 3*n;
            int row = 2 * n - 1;
            if (n % 2 == 0)
            {
                row = 2 * n;
            }
            //top
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}*", new string('-', dash));
                Console.Write("{0}*", new string('-', dashMid));
                Console.Write("{0}", new string('-', dashRight));
                dashMid += 1;
                dashRight -= 1;
                Console.WriteLine();
            }
            //middle
            dash = n - 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("{0}*{1}*{2}",new string('*',star),new string('-',dash),new string('-',dash));
                Console.WriteLine();
            }

            //bottom
            dash = 3 * n;
            dashMid = n - 1;
            dashRight = n - 1;
            for (int i = 0; i < n/2-1; i++)
            {
                Console.Write("{0}*{1}*{2}",new string('-',dash),new string('-',dashMid),new string('-',dashRight));

                dash -= 1;
                dashMid += 2;
                dashRight -= 1;
                Console.WriteLine();
            }
            //last line
            Console.WriteLine("{0}*{1}*{2}",new string('-',dash),new string('*',dashMid),new string('-',dashRight));
        }
    }
}
