using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double thirth = double.Parse(Console.ReadLine());

            double result = first + second + thirth;
            if (result >= 0 && result <= 9)
            {
                Console.WriteLine("0" + ":" + "0" + (result));
            }
            if (result>=10 && result <= 59)
            {
                Console.WriteLine("0" + ":" + (result));
            }
            if (result > 59 && result <= 119)
            {
                if ((result - 60) <= 9)
                {
                    Console.WriteLine("1" + ":" + "0" + (result - 60));
                }
                else
                {
                    Console.WriteLine("1" + ":" + (result - 60));
                }
            }
            if (result > 119 && result <= 179)
            {
                if ((result - 120) <= 9)
                {
                    Console.WriteLine("2" + ":" + "0" + (result - 120));
                }
                else
                {
                    Console.WriteLine("2" + ":" + (result - 120));
                }
            } 
        }
    }
}
