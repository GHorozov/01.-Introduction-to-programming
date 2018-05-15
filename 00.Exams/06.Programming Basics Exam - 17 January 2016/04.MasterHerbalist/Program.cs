using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MasterHerbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyExpenses = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            decimal totalAmountOfMoneyForSeason = 0;
            int days = 0;

            while (command != "Season Over")
            {
                string[] action = command.Split(' ');
                int hours = int.Parse(action[0]);
                string path = action[1];
                int price = int.Parse(action[2]);
                int herbs = 0;
                for (int i = 0; i < hours; i++)
                {
                    if (path[i % path.Length] == 'H')
                    {
                        herbs++;
                    }
                }
                days += 1;
                totalAmountOfMoneyForSeason += herbs*price;
                command = Console.ReadLine();
            }
            decimal averageEarnings = totalAmountOfMoneyForSeason / days;
            if(averageEarnings>= dailyExpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", averageEarnings- dailyExpenses);
            }
            else
            {
                decimal totalExpenses = dailyExpenses * days;
                Console.WriteLine("We are in the red. Money needed: {0}.", totalExpenses - totalAmountOfMoneyForSeason);
            }
        }
    }
}
