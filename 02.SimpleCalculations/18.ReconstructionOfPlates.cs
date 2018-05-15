using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ReconstructionOfPlates
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double wPlate= double.Parse(Console.ReadLine());
            double lPlate= double.Parse(Console.ReadLine());
            double wBench = double.Parse(Console.ReadLine());
            double lBench = double.Parse(Console.ReadLine());

            double placeArea = n * n;
            double plateArea = wPlate * lPlate;
            double benchArea = wBench * lBench;

            double numberOfPlateForComplition = (placeArea - benchArea) / plateArea;
            double timeForConplition = numberOfPlateForComplition * 0.2;
            Console.WriteLine(numberOfPlateForComplition);
            Console.WriteLine(timeForConplition);
        }
    }
}
