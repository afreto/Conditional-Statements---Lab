using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            //square, rectangle, circle или triangle

            //⦁	Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:f3}");
            }
            //⦁	Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:f3}");
            }
            //⦁	Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * radius * radius:f3}");
            }

            //⦁	Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и дължината на височината към нея.
            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(sideA / 2) * sideB:f3}");
            }




        }
    }
}
