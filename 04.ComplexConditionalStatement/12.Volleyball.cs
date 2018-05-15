using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double allGames = 0.0;
            double inSofia = 48 - h;
             double notOnWorkPlays = inSofia * (3.0 / 4);
            double holidayPlay = p * (2.0 / 3);
            if (year == "leap")
            {
                allGames = notOnWorkPlays + h + holidayPlay;
                allGames = (allGames * 0.15)+allGames;
                Console.WriteLine(Math.Truncate(allGames));
            }
            else if (year == "normal")
            {
                allGames = notOnWorkPlays + h + holidayPlay;
                Console.WriteLine(Math.Truncate(allGames));
            }
            
        }
    }
}
