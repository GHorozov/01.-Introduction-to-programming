using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            double n = double.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (n >= 0 && n <= 100)
            {
                bonusPoints = 5;
           
            if (n % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (n % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine("Bonus score: {0}\nTotal score: {1}", bonusPoints, n + bonusPoints);
            }



            if (n > 100 && n <= 1000)
            {
                bonusPoints = (n * 20) / 100;
           
            if (n % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (n % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine("Bonus score: {0}\nTotal score: {1}", bonusPoints, n + bonusPoints);
            }

            if (n > 1000 && n <= 1000000)
            {
                bonusPoints = (n * 10) / 100;
            

            if (n % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (n % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine("Bonus score: {0}\nTotal score: {1}", bonusPoints, n + bonusPoints);
            }
        }
    }
}

