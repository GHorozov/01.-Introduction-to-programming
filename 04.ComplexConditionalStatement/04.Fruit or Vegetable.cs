using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] fruit = new string[] { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = new string[] { "tomato", "cucumber", "pepper", "carrot" };

            for (int f = 0; f < fruit.Length; f++)
            {

                if (str == "banana" || str == "apple" || str == "kiwi" || str == "cherry" || str == "lemon" || str == "grapes")
                {
                    Console.WriteLine("fruit");
                    return;
                }
            }

            for (int v = 0; v < vegetables.Length; v++)
            {
                if(str== "tomato"|| str == "cucumber"|| str == "pepper" || str == "carrot")
                {
                    Console.WriteLine("vegetable");
                    return;
                }
            }
            Console.WriteLine("unknown");
       }
   }
}
