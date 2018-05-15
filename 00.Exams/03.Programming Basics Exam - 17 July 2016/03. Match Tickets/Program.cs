using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double transportation;
            double costs;
            double moneyForNormalTickets = numberOfPeople * 249.99;
            double moneyForVIPTickets = numberOfPeople * 499.99;

            if (numberOfPeople >=1 && numberOfPeople <= 4)
            {

                transportation = budjet * 0.75;
                if (category == "Normal")
                {
                    costs = transportation + moneyForNormalTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.",(budjet-costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs-budjet));
                    }

                }
                if (category == "VIP")
                {
                    costs = transportation + moneyForVIPTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }
                }
            }
            else if(numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                transportation = budjet * 0.60;
                if (category == "Normal")
                {
                    costs = transportation + moneyForNormalTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }

                }
                if (category == "VIP")
                {
                    costs = transportation + moneyForVIPTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }
                }
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                transportation = budjet * 0.50;
                if (category == "Normal")
                {
                    costs = transportation + moneyForNormalTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }

                }
                if (category == "VIP")
                {
                    costs = transportation + moneyForVIPTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }
                }
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                transportation = budjet * 0.40;
                if (category == "Normal")
                {
                    costs = transportation + moneyForNormalTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }

                }
                if (category == "VIP")
                {
                    costs = transportation + moneyForVIPTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }
                }
            }
            else if(numberOfPeople >= 50)
            {
                transportation = budjet * 0.25;
                if (category == "Normal")
                {
                    costs = transportation + moneyForNormalTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }

                }
                if (category == "VIP")
                {
                    costs = transportation + moneyForVIPTickets;
                    if (budjet > costs)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", (budjet - costs));
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", (costs - budjet));
                    }
                }
            }
        }
    }
}
