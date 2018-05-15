using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeSpan = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;
  
            for (int i = 1; i <= timeSpan; i++)
            {
                int numberOfPatients = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (untreated> treated))
                {
                    doctors++;
                }
                if (numberOfPatients > doctors)
                {
                    treated += doctors;
                    untreated += numberOfPatients - doctors;
                }
                else
                {
                    treated += numberOfPatients;
                }
               
            }
            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.",treated ,untreated);
        }
    }
}
