using System;

namespace _7._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int numOfPuzzles = int.Parse(Console.ReadLine());
            int numOfToys = int.Parse(Console.ReadLine());
            int numOfBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());
            int numOfTrucs = int.Parse(Console.ReadLine());

            double totalSum = numOfPuzzles * 2.60 + numOfToys * 3 + numOfBears * 4.10 + numOfMinions * 8.20 + numOfTrucs * 2;
            totalSum -= totalSum * 0.10;
            int totalNumOfToys = numOfBears + numOfMinions + numOfPuzzles + numOfToys + numOfTrucs;
            if (totalNumOfToys >= 50)
            {
                totalSum -= totalSum * 0.25;
            }

            if (totalSum >= priceOfHoliday)
            {
                Console.WriteLine($"Yes! {totalSum - priceOfHoliday:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfHoliday - totalSum:f2} lv needed.");
            }
        }
    }
}
