using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = n / 2;
            int percent = n;
            int midRow = n - 2;
            if (n % 2 == 0)
            {
                percent = n - 1;
                row = n / 2 - 1;
                midRow = n - 2;
            }
            Console.WriteLine(new string('%',2*n));

            for (int i = 1; i <= row; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ',2*n-2));
                Console.WriteLine("%");
            }

            Console.WriteLine("%{0}**{0}%",new string(' ',midRow));

            for (int i = 1; i <= row; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("%");
            }

            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
