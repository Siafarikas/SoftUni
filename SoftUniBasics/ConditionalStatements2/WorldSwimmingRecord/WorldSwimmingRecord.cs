using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double recordInSecs = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double oneMeterInSecs = double.Parse(Console.ReadLine());

            double ivansTime = oneMeterInSecs * distanceInM;
            double timesSlowed = Math.Floor(distanceInM / 15);
            ivansTime = ivansTime + timesSlowed * 12.5;

            if (ivansTime < recordInSecs)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivansTime - recordInSecs:f2} seconds slower.");
            }
        }
    }
}
