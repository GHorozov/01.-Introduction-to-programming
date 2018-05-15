using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnTopOfLine
{
    class PointOnTopOfLine
    {
        static void Main(string[] args)
        {        
            int first = int.Parse(Console.ReadLine());         
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int max = Math.Max(first, second);
            int min = Math.Min(first, second);

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
            }
            else 
            {
                Console.WriteLine("out");
            }

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second) && point <= ((min+max) / 2))
            {
                Console.WriteLine(point-min);
            }
            else if(point >= Math.Min(first, second) && point <= Math.Max(first, second) && point > ((min + max) / 2))
            {
                Console.WriteLine(Math.Abs(max -point));
            }
              
            if(point < Math.Min(first, second))
            {
                Console.WriteLine(Math.Abs(min-point));
            }
            else if (point > max)
            {
                Console.WriteLine(Math.Abs(point -max));
            }
        }
    }
}
