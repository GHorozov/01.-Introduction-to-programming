using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TubeInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            
            double Pipe1 = (double)P1 * H;
            double Pipe2 = (double)P2 * H;
            double Volume = Pipe1 + Pipe2;
            double Pipe1Percent = (Pipe1 / Volume) * 100;
            double Pipe2Percent = (Pipe2 / Volume) * 100;
            double PercentOfVolume = (Volume / V) * 100;

            int PercVol = (int)PercentOfVolume;          //zaradi judje sistemata gi preobrasuvam ina4e e izli6no
            int Pi1 =(int)Math.Floor(Pipe1Percent);
            int pi2 = (int)Math.Floor(Pipe2Percent);

            double Overflow = Volume - V;
            if (PercentOfVolume <= 100)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",PercVol,Pi1,pi2);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",H,Overflow);
            }
        }
    }
}
