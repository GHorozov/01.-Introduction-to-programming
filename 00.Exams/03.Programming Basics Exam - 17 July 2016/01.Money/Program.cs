using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBitcoin = int.Parse(Console.ReadLine());
            double numUan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            //Bitcoin
            double allLevaFromBitcoin = numBitcoin * 1168;
                   
            //Uans
            double allDollarsFromUan = numUan * (double)0.15;
            double sumLevaFromDollars = allDollarsFromUan * (double)1.76;

            double sumBitcoinUanInLeva = allLevaFromBitcoin + sumLevaFromDollars;
            double convertToEuro = sumBitcoinUanInLeva / (double)1.95;
            double percentCommision = (convertToEuro * commision) / 100;
            double finalMoney = convertToEuro - percentCommision;

           
            Console.WriteLine("{0}",finalMoney);
        }
    }
}
