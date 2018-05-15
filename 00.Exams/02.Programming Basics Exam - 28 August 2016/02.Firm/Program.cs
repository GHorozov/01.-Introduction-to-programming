using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int nessesaryHours = int.Parse(Console.ReadLine());
            double daysLeft = double.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double learning = daysLeft * 0.10;
            double netDaysForWork = daysLeft - learning;
            double workingHours = netDaysForWork * 8;
            double hoursOvertime = overtimeWorkers * (2*daysLeft);
            double allHoursLeft = workingHours + hoursOvertime;
            double differenceHours = nessesaryHours - allHoursLeft;

            if (differenceHours <= 0)
            {
                Console.WriteLine("Yes!{0} hours left.",Math.Abs(Math.Truncate(differenceHours)));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Ceiling(differenceHours));
            }

        }
    }
}
