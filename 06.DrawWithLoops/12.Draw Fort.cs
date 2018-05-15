using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //// re6enie nomer-III
            //int width = 2 * n;
            //int row = n / 2; // row -> ^
            //// top
            //Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', row), new string('_', width - ((2 * row) + 4)));
            //// middle
            //for (int i = 0; i < n - 3; i++)
            //{
            //    for (int j = 0; j < 2 * n; j++)
            //    {
            //        if (j == 0 || j == 2 * n - 1)
            //        {
            //            Console.Write("|");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //// bottom
            //Console.WriteLine("|{0}{1}{0}|", new string(' ', row + 1), new string('_', width - ((2 * row) + 4)));
            //Console.WriteLine(@"\{0}/{1}\{0}/", new string('_', row), new string(' ', width - ((2 * row) + 4)));






            // re6enie nomer-I
            int fordAdge = (n - 1) / 2;
            int mid = (n - 1) / 2;
            int pike = (n - 1) / 2;
            if (n % 2 == 0)
            {
                fordAdge = n / 2;
                mid = n / 2;
                pike = n - 3;
            }
            if (n == 3 || n == 4)
            {
                mid = 0;
            }
            Console.WriteLine(@"/{0}\{1}/{0}\", new string('^', fordAdge), new string('_', mid));

            for (int i = 1; i <= pike; i++)
            {
                Console.WriteLine(@"|{0} {1} {0}|", new string(' ', fordAdge), new string(' ', mid), new string(' ', fordAdge));
            }
            if (n > 3)
            {
                Console.WriteLine(@"|{0} {1} {0}|", new string(' ', fordAdge), new string('_', mid), new string(' ', fordAdge));
            }
            Console.WriteLine(@"\{0}/{1}\{0}/", new string('_', fordAdge), new string(' ', mid));


            // re6enie nomer-II

            ////top
            //Console.Write("/" + new string('^', n / 2) + @"\");
            //if (n >= 5)
            //{               
            //    if (n % 2 == 0)
            //    {

            //        Console.Write(new string('_', n / 2));
            //    }
            //    else
            //    {
            //        Console.Write(new string('_', (n - 1) / 2));
            //    }
            //}
            //Console.WriteLine("/" + new string('^', n / 2) + @"\");


            ////middle
            //for (int i = 1; i < n - 2; i++)
            //{
            //    if (n == 3)
            //    {
            //        Console.WriteLine("|" + new string(' ', 4) + "|");
            //    }
            //    if (n == 4)
            //    {
            //        Console.WriteLine("|" + new string(' ', 6) + "|");

            //    }
            //    if (n % 2 == 0 && n != 4)
            //    {
            //        Console.WriteLine("|" + new string(' ', (n / 2) + 1) + new string(' ', (n / 2)) + new string(' ', 1 + (n / 2)) + "|");
            //    }
            //    else if (n != 4 && n != 3)
            //    {
            //        Console.WriteLine("|" + new string(' ', (n / 2) + 1) + new string(' ', (n - 1) / 2) + new string(' ', (n / 2) + 1) + "|");
            //    }               
            //}
            //if (n % 2 == 0 && n!= 3 && n!=4 )
            //{
            //    Console.WriteLine("|" + new string(' ', (n / 2) + 1) + new string('_', n / 2) + new string(' ', 1 + (n / 2)) + "|");
            //}
            //else if(n%2==1 && n != 3 && n != 4)
            //{
            //    Console.WriteLine("|" + new string(' ', (n / 2) + 1) + new string('_', (n - 1) / 2) + new string(' ', (n / 2) + 1) + "|");
            //}
            //else
            //{
            //    Console.WriteLine("|" + new string(' ', (n / 2) + 1)  + new string(' ', (n / 2) + 1) + "|");
            //}


            ////bottom
            //Console.Write(@"\" + new string('_', n / 2) + "/");
            //if (n >= 5)
            //{
            //    if (n % 2 == 0 )
            //    {                    
            //            Console.Write(new string(' ', n / 2));                   
            //    }
            //    else
            //    {
            //        Console.Write(new string(' ', (n - 1) / 2));
            //    }
            //}
            //Console.WriteLine(@"\" + new string('_', n / 2) + "/");
        }
    }
}
