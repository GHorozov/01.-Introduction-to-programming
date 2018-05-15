using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DaysBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            birthDay = birthDay.AddDays(999);
            Console.WriteLine(birthDay.ToString("dd-MM-yyyy"));
        }
    }
}
