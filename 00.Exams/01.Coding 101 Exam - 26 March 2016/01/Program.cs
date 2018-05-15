using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int weightVegetables = int.Parse(Console.ReadLine());
            int weightFruits = int.Parse(Console.ReadLine());

            double finalPriceVegetables = priceVegetables * weightVegetables;
            double finalPriceFruits = priceFruits * weightFruits;

            double priceInEuroVegetables = finalPriceVegetables / 1.94;
            double priceInEuroFruits = finalPriceFruits / 1.94;

            Console.WriteLine(priceInEuroVegetables + priceInEuroFruits);

        }
    }
}
