using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int greater = Math.Max(a, b);
            int lesser = Math.Min(a, b);

            while (lesser != 0)
            {
                int reminder = greater % lesser;
                greater = lesser;
                lesser = reminder;
            }
            Console.WriteLine(greater);
        }
    }
}
