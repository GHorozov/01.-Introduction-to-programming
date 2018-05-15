using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImpressTheGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint payRubles = uint.Parse(Console.ReadLine());
            uint payDollars = uint.Parse(Console.ReadLine());
            uint payEuro = uint.Parse(Console.ReadLine());
            uint payLevaB = uint.Parse(Console.ReadLine());
            uint payLevaM = uint.Parse(Console.ReadLine());

            decimal rublesGameInLeva = (payRubles / 100) * (decimal)3.5;
            decimal dollarsGameInLeva = payDollars * (decimal)1.5;
            decimal euroGameInLeva = payEuro * (decimal)1.95;
            decimal levaBGame = payLevaB / 2;
            decimal levaM = (decimal)payLevaM;

            decimal[] biggestPrice = { rublesGameInLeva, dollarsGameInLeva, euroGameInLeva, euroGameInLeva, levaBGame, levaM };
            Console.WriteLine("{0:f2}", Math.Ceiling(biggestPrice.Max()));

        }
    }
}
