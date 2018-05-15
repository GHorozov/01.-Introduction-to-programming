using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dot = n;
            int downLine = 2 * n - 1;
            //top line
            Console.WriteLine("{0}{1}{0}",new string('.',n+1),new string('_',2*n+1));

            //upper part
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}",new string('.',dot),new string('_',downLine));
                dot -= 1;
                downLine += 2;
            }

            // middle line
            int midLine = 2*n - 3;
            Console.WriteLine(@"//{0}STOP!{0}\\",new string('_',midLine));

            //down part
            dot = 0;
            downLine = 4 * n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}",new string('.',dot),new string('_',downLine));
                dot += 1;
                downLine -= 2;
            }
            Console.WriteLine();
        }
    }
}
