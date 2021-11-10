using System;

namespace SuppliesForSchool
{
    class SuppliesForSchool
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double bleach = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cost = (pencils * 5.80 + markers * 7.20 + bleach * 1.20);
            cost = cost - cost * discount / 100;
            Console.WriteLine($"{cost:f3}");
        }
    }
}
