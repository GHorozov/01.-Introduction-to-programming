using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedAmoundOfCakes = int.Parse(Console.ReadLine());
            decimal kilogramsFlourForOneCake = decimal.Parse(Console.ReadLine());
            int availableKilogramsOfFlour = int.Parse(Console.ReadLine());
            int availableAmoundOfTruffles = int.Parse(Console.ReadLine());
            int priceOfOneTruffles = int.Parse(Console.ReadLine());

            decimal numberOfCakes = availableKilogramsOfFlour / kilogramsFlourForOneCake;
            decimal neededQuantityOfFlour = kilogramsFlourForOneCake * wantedAmoundOfCakes;
            decimal costForTruffels = (decimal)availableAmoundOfTruffles * (decimal)priceOfOneTruffles;
            decimal cakePrice = ((costForTruffels / (decimal)wantedAmoundOfCakes) * 1.25m);

            if (numberOfCakes >= wantedAmoundOfCakes)
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
            }
            else
            {
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", Math.Truncate(numberOfCakes), (neededQuantityOfFlour - availableKilogramsOfFlour));
            }
        }
    }
}
