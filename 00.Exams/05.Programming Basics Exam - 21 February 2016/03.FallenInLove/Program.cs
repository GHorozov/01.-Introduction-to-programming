using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tilda = 1;
            int dot = 2*n - 2;
            int midDot = 2;
            //top line
            Console.WriteLine("##{0}##{0}##",new string('.',2*n));

            //secomd top
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",new string('~',tilda),new string('.',dot),new string('.',midDot));

                tilda += 1;
                dot -= 2;
                midDot += 2;
            }

            //mid part
            dot = 1;
            tilda = n;
            midDot = 2 * n;
            for (int i = 1; i <= n+1; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",new string('.',dot),new string('~',tilda),new string('.',midDot));
                dot += 2;
                tilda -= 1;
                midDot -= 2;
            }

            //bottom part
            dot = 2 * n + 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.',dot));
            }
        }
    }
}
