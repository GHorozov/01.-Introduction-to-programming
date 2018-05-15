using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumP1 = 0.0;
            double sumP2 = 0.0;
            double sumP3 = 0.0;
            double sumP4 = 0.0;
            double sumP5 = 0.0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    sumP1 += 1;
                    p1 = (sumP1 / n) * 100;
                }
                else if(num >=200 && num < 400)
                {
                    sumP2 += 1;
                    p2 = (sumP2 / n) * 100;
                }
                else if (num >= 400 && num < 600)
                {
                    sumP3 += 1;
                    p3 = (sumP3 / n) * 100;
                }
                else if (num >= 600 && num <800)
                {
                    sumP4 += 1;
                    p4 = (sumP4 / n) * 100;
                }
                else if (num >= 800 )
                {
                    sumP5 += 1;
                    p5= (sumP5/ n) * 100;
                }
            }
            Console.WriteLine("\n{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%\n",p1,p2,p3,p4,p5);
        }
    }
}
