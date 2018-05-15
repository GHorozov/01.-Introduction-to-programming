using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double result = 0;
            switch (projection)
            {
                case "Premiere":
                    result = (row * col) * 12;
                    break;
                case "Normal":
                    result = (row * col) * 7.5;
                    break;
                case "Discount":
                    result = (row * col) * 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2}",result);
        }
    }
}
