using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double widthPlate = double.Parse(Console.ReadLine());
            double lenghtPlate = double.Parse(Console.ReadLine());
            int widthBench = int.Parse(Console.ReadLine());
            int lenghtBench = int.Parse(Console.ReadLine());

            int areaSize = area * area;
            double plateSize = widthPlate * lenghtPlate;
            int benchSize = widthBench * lenghtBench;
            int netArea = areaSize - benchSize;
            double neededPlates = netArea / plateSize;
            double neededTime = neededPlates * 0.2;

            Console.WriteLine("{0}\n{1}",neededPlates,neededTime);
        }
    }
}
