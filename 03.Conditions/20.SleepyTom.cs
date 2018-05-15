using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int workPlay = 63;
            int freePlay = 127;
            int workDaysInYear = 365 - freeDays;
            int realTimeForPlay = workDaysInYear * workPlay + freeDays * freePlay;
            int normForTom = 30000 - realTimeForPlay;

            //var result = TimeSpan.FromMinutes(normForTom); //   I -na4in
            //var hours = (int)result.TotalHours;
            //var minutes = result.Minutes;


            var hours = (int)normForTom / 60;               // II -na4in
            var minutes = normForTom % 60;
            if (realTimeForPlay <= 30000)
            {
                Console.WriteLine("“Tom sleeps well”\n{0} hours and {1} minutes less for play",hours,minutes);
            }
            else
            {
                Console.WriteLine("“Tom will run away”\n“{0} hours and {1} minutes more for play” ", Math.Abs(hours), Math.Abs(minutes));
            }
        
        }
    }
}
