using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapeForSquareMeter = double.Parse(Console.ReadLine());
            int wishLitersWine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double allQuantityGrape = area * grapeForSquareMeter;
            double quantityGrapeForWine = allQuantityGrape * 0.4;
            double wineProduceQuantity = quantityGrapeForWine / 2.5;
            if(wineProduceQuantity >= wishLitersWine)
            {
                double wineLeft = wineProduceQuantity - wishLitersWine;
                double forWorkers = wineLeft / numberOfWorkers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wineProduceQuantity));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(forWorkers));

            }
            else
            {
                double wineNeeded = wishLitersWine - wineProduceQuantity;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(wineNeeded));
            }
        }
    }
}
