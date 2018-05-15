using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double pipeOneLitters = P1 * H;
            double pipeTwolitters = P2 * H;
            double allLitters = pipeOneLitters + pipeTwolitters;

            double pipeOnePercent = (pipeOneLitters / allLitters) * 100;
            double pipeTwoPercent = (pipeTwolitters / allLitters) * 100;
            double allPoolPercent = (allLitters / V) * 100;
            int allPerc = (int)allPoolPercent;
            int pipe1 = (int)Math.Floor(pipeOnePercent);
            int pipe2 = (int)Math.Floor(pipeTwoPercent);
            double isFull = V - allLitters;
            if (V <= allLitters)
            {
                isFull = Math.Abs(isFull);
            }

            if (allPoolPercent <= 100)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", allPerc,pipe1 ,pipe2 );
            }
            else if(allPoolPercent>100)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, isFull);
            }
        }
    }
}
