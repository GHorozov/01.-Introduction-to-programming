using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendHometown = int.Parse(Console.ReadLine());

            double normalWeekends = (48 - weekendHometown) * (3.0 / 4.0);
            double playHolidays = (holidays*(2.0/3.0));
            double totalPlay = normalWeekends+ playHolidays + weekendHometown;
            if (year == "leap")
            {
                totalPlay = totalPlay + (totalPlay * 0.15);
            }
            Console.WriteLine(Math.Truncate(totalPlay));
        }
    }
}
