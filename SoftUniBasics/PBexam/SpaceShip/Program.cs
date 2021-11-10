using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeightPeople = double.Parse(Console.ReadLine());

            double shipVol = width * length * height;
            double roomVol = (averageHeightPeople + 0.40) * 2 * 2;
            double astronauts = shipVol / roomVol;
            astronauts = Math.Floor(astronauts);
            if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
