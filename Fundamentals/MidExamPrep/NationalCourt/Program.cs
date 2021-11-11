using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoplePerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                peoplePerHour += int.Parse(Console.ReadLine());
            }
            int peopleCount = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;
            int workingHoursCount = 0;
            while (true)
            {
                if (peopleCount <= 0)
                {
                    Console.WriteLine($"Time needed: {hoursNeeded}h.");
                    break;
                }

                peopleCount -= peoplePerHour;
                hoursNeeded++;
                workingHoursCount++;
                if (workingHoursCount % 3 == 0)
                {
                    if (peopleCount > 0)
                    {
                        hoursNeeded++;
                    }
                }
            }

        }
    }
}
