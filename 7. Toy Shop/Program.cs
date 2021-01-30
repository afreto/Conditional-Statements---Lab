using System;

namespace _7._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни.С парите, които ще спечели иска да отиде на екскурзия.Да се напише програма, която пресмята печалбата от поръчката.
            //Цени на играчките:
            //⦁	Пъзел - 2.60 лв.
            //⦁	Говореща кукла -3 лв.
            //⦁	Плюшено мече -4.10 лв.
            //⦁	Миньон - 8.20 лв.
            //⦁	Камионче - 2 лв.
            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25 % от общата цена. От спечелените пари Петя трябва да даде 10 % за наема на магазина.Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
            //От конзолата се четат 6 реда:
            //⦁	Цена на екскурзията - реално число в интервала[1.00 … 10000.00]
            double priceOfHoliday = double.Parse(Console.ReadLine());
            //⦁	Брой пъзели -цяло число в интервала[0… 1000]
            int numOfPuzzles = int.Parse(Console.ReadLine());
            //⦁	Брой говорещи кукли - цяло число в интервала[0 … 1000]
            int numOfToys = int.Parse(Console.ReadLine());
            //⦁	Брой плюшени мечета - цяло число в интервала[0 … 1000]
            int numOfBears = int.Parse(Console.ReadLine());
            //⦁	Брой миньони -цяло число в интервала[0 … 1000]
            int numOfMinions = int.Parse(Console.ReadLine());
            //⦁	Брой камиончета -цяло число в интервала[0 … 1000]
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



            //На конзолата се отпечатва:
            //⦁	Ако парите са достатъчни се отпечатва:
            //⦁	"Yes! {оставащите пари} lv left."
            //⦁	Ако парите НЕ са достатъчни се отпечатва:
            //⦁	"Not enough money! {недостигащите пари} lv needed."
            //Резултатът трябва да се форматира до втория знак след десетичната запетая.



        }
    }
}
