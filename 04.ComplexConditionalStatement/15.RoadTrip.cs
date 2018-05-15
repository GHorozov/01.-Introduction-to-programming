using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            var result = 0.0;
            if (budjet > 10 && budjet <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    result = budjet * 0.3;
                    Console.WriteLine("Camp - {0:f2}",result);
                }
                else if (season == "winter")
                {
                    result = budjet * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", result);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else if (budjet <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    result = budjet * 0.4;
                    Console.WriteLine("Camp - {0:f2}", result);
                }
                else if (season == "winter")
                {
                    result = budjet * 0.8;
                    Console.WriteLine("Hotel - {0:f2}", result);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }
            else if (budjet > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                if (season == "summer" || season== "winter")
                {
                    result = budjet * 0.9;
                    Console.WriteLine("Camp - {0:f2}", result);
                }    
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }
            else
            {
                Console.WriteLine("Invalid input.");
            }


        }
    }
}
