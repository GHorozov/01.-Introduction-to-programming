using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int star = n - 1;
            int dotLeft = n - 1;
            int dotMid = 3 * n;
            //top line
            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*',3*n));
            
            //above middle line
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',dotLeft),new string('.',dotMid));
                dotLeft -= 1;
                dotMid += 2;   
            }
            dotMid = dotMid - 2;
            //middle line
            Console.WriteLine("{0}",new string('*',n*5));

            //under middle line
            dotLeft = 1;
            for (int i = 1; i <=2*n ; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',dotLeft),new string('.',dotMid));
                dotLeft += 1;
                dotMid -= 2;
            }

            //bottom line
            Console.WriteLine("{0}*{1}*{0}",new string('.',dotLeft),new string('*',dotMid));

        }
    }
}
