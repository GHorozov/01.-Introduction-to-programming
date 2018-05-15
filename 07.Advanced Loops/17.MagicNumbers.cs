using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int n1 = 0; n1 <= 9; n1++)
            {
                for (int n2 = 0; n2 <= 9; n2++)
                {
                    for (int n3 = 0; n3 <= 9; n3++)
                    {
                        for (int n4 = 0; n4 <= 9; n4++)
                        {
                            for (int n5= 0; n5 <= 9; n5++)
                            {
                                for (int n6 = 0; n6 <= 9; n6++)
                                {
                                    if (n1 * n2 * n3 * n4 * n5 * n6 == n)
                                    {
                                        //Console.WriteLine("{0}{1}{2}{3}{4}{5} -> {0}*{1}*{2}*{3}*{4}*{5} = {6}", n1, n2,n3,n4,n5,n6,n);   -- po-krasivo ispisvane zaradi judje drugoto
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", n1, n2, n3, n4, n5, n6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
