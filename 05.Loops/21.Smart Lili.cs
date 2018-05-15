using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            double singleToyPrice = double.Parse(Console.ReadLine());
            double evenBDMoney = 10;
            double oddBDToys = 0.0;
            double moneyForToys = 0.0;
            double allMoneyCollected = 0.0;
            double increment = 10;
            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0 && (i != 2))
                {
                    increment += 10;
                    evenBDMoney += increment;
                    evenBDMoney = evenBDMoney - 1;
                }
            }
            evenBDMoney = evenBDMoney - 1;


            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 1)
                {
                    oddBDToys += 1;
                }
            }
            moneyForToys = oddBDToys * singleToyPrice;


            allMoneyCollected = evenBDMoney + moneyForToys;
            if (allMoneyCollected > washingmachinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", allMoneyCollected - washingmachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingmachinePrice - allMoneyCollected);
            }
        }
    }
}
