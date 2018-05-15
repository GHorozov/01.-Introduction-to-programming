using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOldPeople = int.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfnights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double ticketPriceOld = 0;
            double ticketPriceStudents = 0;
            double expenceTransport = 0;
            if(transport== "train")
            {
                ticketPriceOld = 24.99;
                ticketPriceStudents = 14.99;
                if((numberOfOldPeople+numberOfStudents) > 50)
                {
                    ticketPriceOld = ticketPriceOld / 2;
                    ticketPriceStudents = ticketPriceStudents / 2;
                }
                expenceTransport = ((ticketPriceOld * numberOfOldPeople)+ (ticketPriceStudents*numberOfStudents)) *2;
                double expenceHotel = numberOfnights * 82.99;
                double commision = (expenceTransport + expenceHotel) *0.10;
                double allSum = (expenceTransport + expenceHotel + commision);
                Console.WriteLine("{0:f2}",allSum);
            }
            else if(transport== "bus")
            {
                ticketPriceOld = 32.50;
                ticketPriceStudents = 28.50;
                expenceTransport = ((ticketPriceOld * numberOfOldPeople) + (ticketPriceStudents * numberOfStudents)) * 2;
                double expenceHotel = numberOfnights * 82.99;
                double commision = (expenceTransport + expenceHotel) * 0.10;
                double allSum = (expenceTransport + expenceHotel + commision);
                Console.WriteLine("{0:f2}", allSum);
            }
            else if(transport== "boat")
            {
                ticketPriceOld = 42.99;
                ticketPriceStudents = 39.99;
                expenceTransport = ((ticketPriceOld * numberOfOldPeople) + (ticketPriceStudents * numberOfStudents)) * 2;
                double expenceHotel = numberOfnights * 82.99;
                double commision = (expenceTransport + expenceHotel) * 0.10;
                double allSum = (expenceTransport + expenceHotel + commision);
                Console.WriteLine("{0:f2}", allSum);

            }
            else if(transport== "airplane")
            {
                ticketPriceOld = 70;
                ticketPriceStudents = 50;
                expenceTransport = ((ticketPriceOld * numberOfOldPeople) + (ticketPriceStudents * numberOfStudents)) * 2;
                double expenceHotel = numberOfnights * 82.99;
                double commision = (expenceTransport + expenceHotel) * 0.10;
                double allSum = (expenceTransport + expenceHotel + commision);
                Console.WriteLine("{0:f2}", allSum);
            }
        }
    }
}
