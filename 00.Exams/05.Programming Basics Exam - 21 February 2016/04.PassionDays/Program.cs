using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PassionDays
{
    class Program
    {
        private static string a;

        static void Main(string[] args)
        {
            decimal totalMoney = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchases = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                string actions = command;
                for (int i = 0; i < actions.Length; i++)
                {
                    decimal price = 0;
                    if (actions[i] >= 65 && actions[i] <= 90)
                    {
                        price = actions[i] * 0.5m;
                        if (totalMoney < price)
                        {
                            continue;
                        }
                        totalMoney -= price;
                        purchases++;
                    }
                    else if (actions[i] >= 97 && actions[i] <= 122)
                    {
                        price = actions[i] * 0.3m;
                        if (totalMoney < price)
                        {
                            continue;
                        }

                        totalMoney -= price;
                        purchases++;
                    }
                    else if (actions[i] == '%')
                    {
                        if (totalMoney > 0)
                        {
                            totalMoney /= 2;
                            purchases++;
                        }
                    }
                    else if (actions[i] == '*')
                    {
                        totalMoney += 10;
                    }
                    else
                    {
                        price = actions[i];
                        if (totalMoney < price)
                        {
                            continue;
                        }

                        totalMoney -= price;
                        purchases++;
                    }

                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", totalMoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, totalMoney);
            }

        }
    }
}
