using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            while (country != "End")
            {
                double price = double.Parse(Console.ReadLine());
                double budget = 0;
                while (budget < price)
                {
                    budget += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }
        }
    }
}
