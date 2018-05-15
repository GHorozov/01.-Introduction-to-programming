using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double washMashine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            double money = 0;
            double toysMoney = 0;
            double allSum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    sum += money;
                    count += 1;
                }
                if (i % 2 == 1)
                {
                    toysMoney += toysPrice;
                }
                            
            }
            allSum = (sum + toysMoney)-count;

            if (allSum >= washMashine)
            {
                double diffrence = allSum - washMashine;
                Console.WriteLine("Yes! {0:f2}",diffrence);
            }
            else
            {
                double diffrence = washMashine -allSum;
                Console.WriteLine("No! {0:f2}",diffrence);
            }
        }
    }
}
