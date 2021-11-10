using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeShoot = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0;

            if (typeShoot == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (typeShoot == "Normal")
            {
                income = rows * columns * 7.50;

            }
            else if (typeShoot == "Discount")
            {
                income = rows * columns * 5.00;
            }

            Console.WriteLine($"{income:f2}");


        }
    }
}
