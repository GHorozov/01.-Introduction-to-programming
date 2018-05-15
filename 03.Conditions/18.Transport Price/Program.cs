using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double price = 0.0;

            if (n > 1 && n < 20)
            {
                if (timeOfDay == "day")
                {
                    price = 0.7 + (n * 0.79);
                    
                }
                else if(timeOfDay == "night")
                {
                    price = 0.7 + (n * 0.9);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }
            }
            else if (n >= 20 && n < 100)
            {
                if(timeOfDay== "day"|| timeOfDay == "night")
                {
                    price = n * 0.09;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }
            }
            else if (n >= 100 && n < 5000)
            {
                if(timeOfDay == "day" || timeOfDay == "night")
                {
                    price = n * 0.06;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            Console.WriteLine("{0}",price);
        }
    }
}
