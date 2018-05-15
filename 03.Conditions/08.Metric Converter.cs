using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double n = double.Parse(Console.ReadLine());
            string metricNumber = Console.ReadLine();
            string metricNnumber2 = Console.ReadLine();
            double result=0.0;
            switch (metricNumber)
            {
                case "m":
                    result = n / 1;
                    break;
                case "mm":
                    result = n / 1000;
                    break;
                case "cm":
                    result = n / 100;
                    break;
                case "mi":
                    result = n / 0.000621371192;
                    break;
                case "in":
                    result = n / 39.3700787;
                    break;
                case "km":
                    result= n / 0.001;
                    break;
                case "ft":
                    result = n / 3.2808399;
                    break;
                case "yd":
                    result = n / 1.0936133;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            switch (metricNnumber2)
            {
                case "m":
                    result = result * 1;
                    break;
                case "mm":
                    result = result * 1000; 
                    break;
                case "cm":
                    result = result * 100;
                    break;
                case "mi":
                    result = result * 0.000621371192;
                    break;
                case "in":
                    result = result * 39.3700787;
                    break;
                case "km":
                    result = result * 0.001;
                    break;
                case "ft":
                    result = result * 3.2808399;
                    break;
                case "yd":
                    result = result * 1.0936133;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("{0} {1}",result, metricNnumber2);
        }
    }
}
