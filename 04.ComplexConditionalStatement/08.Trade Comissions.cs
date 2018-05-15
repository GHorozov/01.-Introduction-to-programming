using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double result = 0.0;
            switch (town)
            {
                case "Sofia":
                    if (s >= 0 && s <= 500)
                    {
                        result = s * 0.05;
                        Console.WriteLine("{0:f2}",result);
                    }
                    else if(s > 500 && s <= 1000)
                    {
                        result = s * 0.07;
                        Console.WriteLine("{0:f2}",result);
                    }
                    else if(s >1000  && s <= 10000)
                    {
                        result = s * 0.08;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 10000)
                    {
                        result = s * 0.12;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (s >= 0 && s <= 500)
                    {
                        result = s * 0.045;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        result = s * 0.075;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        result = s * 0.1;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 10000)
                    {
                        result = s * 0.13;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (s >= 0 && s <= 500)
                    {
                        result = s * 0.055;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        result = s * 0.08;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        result = s * 0.12;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else if (s > 10000)
                    {
                        result = s * 0.145;
                        Console.WriteLine("{0:f2}", result);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
