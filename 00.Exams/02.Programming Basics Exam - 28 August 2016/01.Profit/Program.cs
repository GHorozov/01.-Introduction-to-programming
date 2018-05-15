using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysInMonth = int.Parse(Console.ReadLine());
            decimal incomeForDay = decimal.Parse(Console.ReadLine());
            decimal USDBGN = decimal.Parse(Console.ReadLine());

            decimal montlyIncome = workDaysInMonth * incomeForDay;
            decimal yearSelary = montlyIncome * 12;
            decimal bonus = montlyIncome * (decimal)2.5;
            decimal yearIncome = yearSelary + bonus;
            decimal percent = yearIncome * (decimal)0.25;
            decimal netIncome = yearIncome - percent;
            decimal incomeForDayInDollars = netIncome / 365;
            decimal incomeForDayInLeva = incomeForDayInDollars * USDBGN;
            Console.WriteLine("{0:f2}",incomeForDayInLeva);
        }
    }
}
