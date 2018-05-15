using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            var time = (hours*60) + minutes+15;
            var finalHours = (time / 60) % 24;
            var finalMinutes = time % 60;
            Console.WriteLine("{0}:{1:00}",finalHours,finalMinutes);
        }
    }
}


