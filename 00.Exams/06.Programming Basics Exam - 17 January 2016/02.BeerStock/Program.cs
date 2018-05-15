using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BeerStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservedBeer = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            long amountOfBeers = 0;

            while (command != "Exam Over")
            {
                string[] action = command.Split(' ');
                string typeOfBeers = action[1];
                long beersNumber = long.Parse(action[0]);

                for (int i = 0; i < 1; i++)
                {
                    if(typeOfBeers == "beers")
                    {
                        amountOfBeers += beersNumber;
                    }
                    else if(typeOfBeers == "cases")
                    {
                        amountOfBeers += (beersNumber * 24);
                    }
                    else if(typeOfBeers == "sixpacks")
                    {
                        amountOfBeers += (beersNumber * 6);
                    }
                }
                command = Console.ReadLine();
            }

            amountOfBeers = amountOfBeers - (amountOfBeers / 100);
            if (reservedBeer > amountOfBeers)
            {
                long beersNeeded = reservedBeer - amountOfBeers;
                long cases = beersNeeded / 24;
                long sixpacks = (beersNeeded - (cases*24)) / 6;
                long beerLeft = beersNeeded - (cases*24) - (sixpacks*6);
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",cases,sixpacks,beerLeft);
            }
            else
            {
                long totalBeerLeft = amountOfBeers - reservedBeer;
                long cases = totalBeerLeft / 24;
                long sixpacks = (totalBeerLeft - (cases*24)) / 6;
                long beerLeft = totalBeerLeft - (cases *24)- (sixpacks*6);
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.",cases,sixpacks,beerLeft);
            }

        }
    }
}
