using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EmergencyRepairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            int emergencyKits = int.Parse(Console.ReadLine());
            int attacks = int.Parse(Console.ReadLine());

            for (int i = 0; i < attacks; i++)
            {
                int num = int.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << num);
            }
            for (int i = 0; i < 64; i++)
            {
                
                ulong mask = 1;
                ulong nextbit = (wall >> i + 1) & mask;
                if ((((mask << i) & wall) == 0) && (((mask << (i + 1)) & wall) == 0) && emergencyKits > 0)
                {
                    if (emergencyKits >= 1)
                    {
                        //Console.WriteLine(Convert.ToString((long)num, 2).PadLeft(64, '0'));
                        wall = wall | (ulong)(mask << i);
                        emergencyKits--;
                        while (emergencyKits >= 1 && nextbit == 0)
                        {
                            ////Console.WriteLine(Convert.ToString((long)num, 2).PadLeft(64, '0'));
                            i++;
                            wall = wall | (ulong)(mask << i);
                            nextbit = (wall >> i + 1) & mask;
                            emergencyKits--;
                        }

                        //Console.WriteLine(Convert.ToString((long)num, 2).PadLeft(64, '0'));
                    }
                }
                if (i == 63 || emergencyKits == 0)
                {
                    break;
                }
            }
            Console.WriteLine(wall);
        }
    }
}
