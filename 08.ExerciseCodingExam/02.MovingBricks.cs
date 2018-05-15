using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movingBricks
{
    class movingBricks
    {
        static void Main(string[] args)
        {
            Console.Write("Quantity of bricks x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantity of workers w: ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Space in loading car m: ");
            int m = int.Parse(Console.ReadLine());

            double bricksWithOneMove = w * m;
            double allMoves = x / bricksWithOneMove;

            Console.WriteLine(Math.Ceiling(allMoves));
        }
    }
}
