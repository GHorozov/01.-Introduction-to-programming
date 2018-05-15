using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeTime = int.Parse(Console.ReadLine());

            int onWork = 365 - freeTime;
            int freePlay = freeTime * 127;
            int onWorkPlay = onWork * 63;
            int realTimeForPlay = freePlay + onWorkPlay;

            if (30000 >= realTimeForPlay)
            {
                int difference = 30000 - realTimeForPlay;
                int hours = difference / 60;
                int min = difference % 60;
                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play", hours, min);
            }
            else
            {
                int difference = realTimeForPlay - 30000;
                int hours = difference / 60;
                int min = difference % 60;
                Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play", hours, min);

            }
        }
    }
}
