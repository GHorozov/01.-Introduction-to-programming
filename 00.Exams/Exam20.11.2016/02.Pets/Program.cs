using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int leftFoodInKg = int.Parse(Console.ReadLine());
            double dogFoodForDayKg = double.Parse(Console.ReadLine());
            double catFoodForDayKg = double.Parse(Console.ReadLine());
            double turtleFoodForDayGrams = double.Parse(Console.ReadLine());

            double dogNeedFoodDay = numberOfDays * dogFoodForDayKg;
            double catNeedFoodDay = numberOfDays * catFoodForDayKg;
            double turtleNeedFoodDay = (numberOfDays * turtleFoodForDayGrams)/1000;

            double sumNeedFoodForDay = dogNeedFoodDay + catNeedFoodDay + turtleNeedFoodDay;

            if(sumNeedFoodForDay <= leftFoodInKg )
            {
                Console.WriteLine("{0} kilos of food left.",Math.Truncate(leftFoodInKg-sumNeedFoodForDay));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(sumNeedFoodForDay - leftFoodInKg));
            }




        }
    }
}
