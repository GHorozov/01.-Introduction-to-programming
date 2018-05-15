using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USD = decimal.Parse(Console.ReadLine());
            decimal BGN = USD * (decimal)1.79549;
            Console.WriteLine(Math.Round(BGN,2));
        }
    }
}
