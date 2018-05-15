using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double sumCar = 0;
            double sumMicrobus = 0;
            double sumSmallBus = 0;
            double sumBus = 0;
            double sumTrain = 0;
            double sumAll = 0;
            for (int i = 1; i <= numberOfGroups; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumAll += num;

                if(num <= 5)
                {
                    sumCar += num;
                }
                else if(num >=6 && num <= 12)
                {
                    sumMicrobus += num;
                }
                else if(num >= 13 && num <= 25)
                {
                    sumSmallBus += num;
                }
                else if (num >= 26 && num <= 40)
                {
                    sumBus += num;
                }
                else if (num >= 41)
                {
                    sumTrain += num;
                }
            }
            double percentCar = (sumCar / sumAll) * 100;
            double percentMicrobus = (sumMicrobus / sumAll) * 100;
            double percentSmallBus = (sumSmallBus / sumAll) * 100;
            double percentBus= (sumBus / sumAll) *100;
            double percentTrain = (sumTrain / sumAll) * 100;

            Console.WriteLine("{0:f2}%", percentCar);
            Console.WriteLine("{0:f2}%", percentMicrobus);
            Console.WriteLine("{0:f2}%", percentSmallBus);
            Console.WriteLine("{0:f2}%", percentBus);
            Console.WriteLine("{0:f2}%", percentTrain);

        }
    }
}
