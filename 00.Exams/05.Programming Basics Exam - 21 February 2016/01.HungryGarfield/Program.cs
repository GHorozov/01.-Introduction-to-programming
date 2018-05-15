using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyUsd = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPriceInLeva = decimal.Parse(Console.ReadLine()) / exchangeRate;
            decimal lasagnaPriceInLeva = decimal.Parse(Console.ReadLine()) / exchangeRate;
            decimal sandwichPriceInLeva= decimal.Parse(Console.ReadLine()) / exchangeRate;
            uint pizzaQuantity= uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal pizzaPriceUSD = pizzaPriceInLeva  * pizzaQuantity;
            decimal lasagnaPriceUSD = lasagnaPriceInLeva  * lasagnaQuantity;
            decimal sandwichPriceUSD = sandwichPriceInLeva  * sandwichQuantity;
            decimal result = (pizzaPriceUSD + lasagnaPriceUSD + sandwichPriceUSD);

            if(moneyUsd - result >=0)
            {
                decimal diff = moneyUsd - result;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.",diff);
            }
            else
            {
                decimal diff = result - moneyUsd;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.",diff);
            }

        }
    }
}
