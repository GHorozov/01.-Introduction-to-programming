using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 0; row < n + 1; row++)
            {

                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }

                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }

                // midle
                Console.Write(" | ");

                //right part
                for (int i = 1; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
