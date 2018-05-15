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
            double priceSkumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double pricePalamud = priceSkumria + (priceSkumria * 0.6);
            double sumPalamud = kgPalamud * pricePalamud;
            double priceSafrid = priceCaca + (priceCaca * 0.8);
            double sumSafrid = kgSafrid * priceSafrid;
            double sumMidi = kgMidi * 7.5;

            double totalPrice = sumPalamud + sumSafrid + sumMidi;

            Console.WriteLine("{0:f2}",totalPrice);



        }
    }
}
