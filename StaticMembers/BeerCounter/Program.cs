using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCounter
{
    class BeerCounter
    {
        public static int beerInStock = 0;
        public static int beersDrankCount = 0;
                
        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beerInStock -= bottlesCount;
            beersDrankCount += bottlesCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while (command != "End")
            {
                int[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                BeerCounter.BuyBeer(input[0]);
                BeerCounter.DrinkBeer(input[1]);

                command = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beersDrankCount}");
        }
    }
}
