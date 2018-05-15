using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y= ");
            int y = int.Parse(Console.ReadLine());
            bool inRectangleHorizontal = (x >= 2 && x <= 12) && (y >= -3 && y <= 1);
            bool inRectangleVerticale = (y >= -5 && y <= 3) && (x >= 4 && x <= 10);
            if (inRectangleHorizontal || inRectangleVerticale)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
