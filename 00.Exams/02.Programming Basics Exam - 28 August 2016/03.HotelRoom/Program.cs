using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                double priceStudio = 50;
                double priceApartment = 65;

                if (numberOfNights <= 7)
                {
                    double resultStudio = numberOfNights * priceStudio;
                    double resultApartment = numberOfNights * priceApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
                else if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    double bonusStudio = priceStudio * 0.05;
                    double priceAfterBonusStudio = priceStudio - bonusStudio;
                    double resultStudio = numberOfNights * priceAfterBonusStudio;
                    double resultApartment = numberOfNights * priceApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
                else if (numberOfNights > 14)
                {
                    double bonusStudio = priceStudio * 0.3;
                    double bonusApartment = priceApartment * 0.10;
                    double priceAfterBonusStudio = priceStudio - bonusStudio;
                    double priceAfterBonusApartment = priceApartment - bonusApartment;
                    double resultStudio = numberOfNights * priceAfterBonusStudio;
                    double resultApartment = numberOfNights * priceAfterBonusApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
            }
            else if (month == "June" || month == "September")
            {
                double priceStudio = 75.2;
                double priceApartment = 68.70;

                if (numberOfNights <= 14)
                {
                    double resultStudio = numberOfNights * priceStudio;
                    double resultApartment = numberOfNights * priceApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
                else if (numberOfNights > 14)
                {
                    double bonusStudio = priceStudio * 0.2;
                    double bonusApartment = priceApartment * 0.10;
                    double priceAfterBonusStudio = priceStudio - bonusStudio;
                    double priceAfterBonusApartment = priceApartment - bonusApartment;
                    double resultStudio = numberOfNights * priceAfterBonusStudio;
                    double resultApartment = numberOfNights * priceAfterBonusApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }

            }
            else if (month == "July" || month == "August")
            {
                double priceStudio = 76;
                double priceApartment = 77;

                if (numberOfNights <= 14)
                {
                    double resultStudio = numberOfNights * priceStudio;
                    double resultApartment = numberOfNights * priceApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
                else if (numberOfNights > 14)
                {
                    double resultStudio = priceStudio * numberOfNights;
                    double bonusApartment = priceApartment * 0.10;
                    double priceAfterBonusApartment = priceApartment - bonusApartment;
                    double resultApartment = numberOfNights * priceAfterBonusApartment;
                    Console.WriteLine("Apartment: {0:f2} lv.", resultApartment);
                    Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
                }
            }         
        }
    }
}
