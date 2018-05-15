using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HayvanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int result = 0;
            for (int abc = 555; abc <= 999; abc++)
            {
               
                int def = abc + diff;
                int ghi = def + diff;

                int num1 = ((abc / 100) % 10) + ((abc / 10) % 10) + (abc % 10);
                int num2 = ((def / 100) % 10) + ((def / 10) % 10) + (def % 10);
                int num3 = ((ghi / 100) % 10) + ((ghi / 10) % 10) + (ghi % 10);

                if (IsAllowedNumber(abc)&& IsAllowedNumber(def)&& IsAllowedNumber(ghi))
                {
                    if ((ghi - def == diff) && (def - abc == diff) && (num1 + num2 + num3 == sum))
                    {

                        Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                        result++;
                    }
                }
                
            }
            if (result == 0)
            {
                Console.WriteLine("No");
            }
        }

             private static bool IsAllowedNumber(int num)
        {
            string digits = num.ToString();
            foreach (var digit in digits)
            {
                if (digit < '5' || digit > '9')
                {
                    return false;
                }
            }
            return true;
        }

    }
}
