using System;

namespace GodzillaVersusKong
{
    class GodzillaVersusKong
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int staff = int.Parse(Console.ReadLine());
            double pricePerClothing = double.Parse(Console.ReadLine());

            double decor = budget / 10;
            double clothing = staff * pricePerClothing;

            if (staff > 150)
            {
                clothing = clothing - clothing / 10;

            }
            if (decor + clothing > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decor + clothing - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - decor - clothing:f2} leva left.");
            }
        }
    }
}
