using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.VegetablesStock
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vegetablesPrice = decimal.Parse(Console.ReadLine());
            decimal fruitsPrice = decimal.Parse(Console.ReadLine());
            decimal wholeVegetablesWeight = decimal.Parse(Console.ReadLine());
            decimal wholeFruitsWeight = decimal.Parse(Console.ReadLine());

            decimal totalSumVegetables = (vegetablesPrice * wholeVegetablesWeight) / (decimal)1.94;
            decimal totalSumFruts=(fruitsPrice*wholeFruitsWeight) / (decimal)1.94;

            Console.WriteLine(totalSumVegetables+totalSumFruts);
        }
    }
}
