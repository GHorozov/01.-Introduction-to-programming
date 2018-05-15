using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            var examTime = (examHour * 60) + examMinute;
            var arrivalTime = (arrivalHour * 60) + arrivalMinute;
            var diffTime = arrivalTime - examTime;
            var secondDiff = examTime - arrivalTime;

            if (diffTime <= 59 && diffTime > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", diffTime);
            }
            else if (diffTime >= 60)
            {
                var hour = diffTime / 60;
                var minutes = diffTime % 60;
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} hours after the start", hour, minutes);
            }
            else if (secondDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else if (secondDiff <= 30 && secondDiff > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", secondDiff);
            }
            else if (secondDiff > 30 && secondDiff < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", secondDiff);
            }
            else if (secondDiff >= 60)
            {
                var hour = secondDiff / 60;
                var minutes = secondDiff % 60;
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1:00} hours before the start", hour, minutes);
            }




            //int hour = Math.Abs(int.Parse(Console.ReadLine()));
            //int minute = Math.Abs(int.Parse(Console.ReadLine()));
            //int arriveHour = Math.Abs(int.Parse(Console.ReadLine()));
            //int arriveMinute = Math.Abs(int.Parse(Console.ReadLine()));

            //int oneHour = 1;
            //int zeroMinutes = 0;
            //string oneHourAndZeroMinutes = oneHour.ToString() + ":" + zeroMinutes.ToString();

            //int zeroHour = 0;
            //int halfHour = 30;
            //string thirteenMinutes = zeroHour.ToString() + ":" + halfHour.ToString();


            //string startTime = hour.ToString() + ":" + minute.ToString();
            //string arriveTime = arriveHour.ToString() + ":" + arriveMinute.ToString();

            //TimeSpan duration = DateTime.Parse(arriveTime).Subtract(DateTime.Parse(startTime));
            //TimeSpan earlyArrival = (DateTime.Parse(startTime)).Subtract(DateTime.Parse(oneHourAndZeroMinutes));
            //TimeSpan startTime2 = TimeSpan.Parse(startTime);
            //TimeSpan arriveTime2 = TimeSpan.Parse(arriveTime);
            //TimeSpan startTimeMinus30 = DateTime.Parse(startTime).Subtract(DateTime.Parse(thirteenMinutes));

            //if (arriveTime2 > startTime2)
            //{
            //    Console.WriteLine("Late");

            //    if (duration <= TimeSpan.Parse(oneHourAndZeroMinutes))
            //    {
            //        if (duration.TotalMinutes > 0)
            //        {
            //            Console.WriteLine("{0} minutes after the start", duration.ToString(@"mm"));
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} minutes after the start", duration.TotalMinutes * -1);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} hours after the start", duration.ToString(@"h\:mm"));
            //    }

            //}
            //else if (arriveTime2 >= startTimeMinus30 && arriveTime2 >= startTimeMinus30)
            //{
            //    Console.WriteLine("On time");
            //    if (startTime2 == arriveTime2)
            //    {

            //    }
            //    else
            //    {
            //        if (duration.TotalMinutes > 0)
            //        {
            //            Console.WriteLine("{0} minutes before the start", duration.ToString(@"mm"));
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} minutes before the start", duration.TotalMinutes * -1);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Early");
            //    if (arriveTime2 < startTimeMinus30 && arriveTime2 > earlyArrival)
            //    {
            //        if (duration.TotalMinutes > 0)
            //        {
            //            Console.WriteLine("{0} minutes before the start", duration.ToString(@"mm"));
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} minutes before the start", duration.TotalMinutes * -1);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} hours before the start", duration.ToString(@"h\:mm"));
            //    }
            //}



        }
    }
}
