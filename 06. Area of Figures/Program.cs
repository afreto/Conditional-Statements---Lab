using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:f3}");
            }
            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:f3}");
            }
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radius * radius:f3}");
            }
            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(sideA / 2) * sideB:f3}");
            }
        }
    }
}
