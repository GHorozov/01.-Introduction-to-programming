using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = decimal.Parse(Console.ReadLine());
            var entryVal = Console.ReadLine();
            var outputVal = Console.ReadLine();
            decimal USD = 1.79549M;
            decimal BGN = 1;
            decimal EUR = 1.95583M;
            decimal GBP = 2.53405M;

            switch (entryVal)
            {
                case "USD":
                    {
                        value = value * USD;
                    }break;
                case "BGN":
                    {
                        value = value * BGN;
                    }break;
                case "EUR":
                    {
                        value = value * EUR;
                    }break;
                case "GBP":
                    {
                        value = value * GBP;
                    }break;
                default:
                    break;
            }
            switch (outputVal)
            {
                case "USD":
                    {
                        value = value / USD;
                    }
                    break;
                case "BGN":
                    {
                        value=value/BGN;
                    }
                    break;
                case "EUR":
                    {
                        value = value / EUR;
                    }
                    break;
                case "GBP":
                    {
                        value = value / GBP;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(value,2) + " " + outputVal);
        }
    }
}
