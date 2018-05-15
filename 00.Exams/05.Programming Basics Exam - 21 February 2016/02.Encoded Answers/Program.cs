using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encoded_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = null;
            int sumA = 0;
            int sumB = 0;
            int sumC = 0;
            int sumD = 0;
            for (int i = 0; i < n; i++)
            {
                uint num = uint.Parse(Console.ReadLine());
                string answer = null;

                if (num % 4 == 0)
                {
                    answer = "a";
                    sumA += 1;
                }
                else if (num % 4 == 1)
                {
                    answer = "b";
                    sumB += 1;
                }
                else if (num % 4 == 2)
                {
                    answer = "c";
                    sumC += 1;
                }
                else 
                {
                    answer = "d";
                    sumD += 1;
                }
                result += answer + ' ';
            }

            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", sumA, sumB, sumC, sumD);
        }
    }
}
