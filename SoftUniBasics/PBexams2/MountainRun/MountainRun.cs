using System;

namespace MountainRun
{
    class MountainRun
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secsForMeter = double.Parse(Console.ReadLine());
            double hisTime = meters * secsForMeter + Math.Floor((meters / 50)) * 30;
            if (hisTime < record)
            {
                Console.WriteLine($"Yes! The new record is {hisTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {hisTime - record:f2} seconds slower.");
            }


        }
    }
}
