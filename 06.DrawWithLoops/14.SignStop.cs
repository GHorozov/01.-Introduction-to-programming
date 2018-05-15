using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dot = n + 1;
            int underLine = 2 * n - 1;
            Console.WriteLine("{0}{1}{0}",new string('.',dot),new string('_',2*n+1));
            dot -= 1;
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}",new string('.',dot),new string('_',underLine));
                dot -= 1;
                underLine += 2;
            }

            Console.WriteLine(@"//{0}STOP!{0}\\",new string('_',(2*n)-3));

            underLine = n * 4 - 1;
            dot = 0;
            for (int i = 0; i < n+1 ; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dot), new string('_', underLine));
                dot += 1;
                underLine -= 2;
            }
        }
    }
}
