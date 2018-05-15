using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // I - na4in
            if(m==2|| m == 02)//poradi gre6en izhod pri 02 month
            {
                d += 1;
            }
            string input = string.Format("{0}-{1:D2}-2016", d, m);
            DateTime date = Convert.ToDateTime(input, new CultureInfo("bg-BG"));
            date = date.AddDays(5);

            Console.WriteLine(date.ToString("d.MM"));



            // II-na4in
            //var year = 2016;
            //DateTime firstDate = new DateTime(year, m, d);
            //DateTime secondDate = firstDate.AddDays(5);
            //Console.WriteLine(secondDate.ToString("d.MM"));
        }
    }
}