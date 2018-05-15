using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IlluminatiLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dot = n - 2;
            int dotLeftRight=0;
            int dotMid = n - 2;
            
            //top line
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

            //second line and down
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}",new string('.',dot), new string('.',dotLeftRight), new string('.',dotMid));
                dot -= 2;
                dotLeftRight += 2;
            }

            // from middle and down
            dot = 1;
            dotLeftRight = dotLeftRight - 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}",new string('.',dot), new string('.',dotLeftRight),new string('.',dotMid));
                dot += 2;
                dotLeftRight -= 2;
            }

            //bottom line
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
