using System;

namespace TrekkingMania
{
    class TrekkingMania
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double totalPeople = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    kilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else
                {
                    everest += peopleInGroup;
                }
            }
            Console.WriteLine($"{musala / totalPeople * 100:f2}%");
            Console.WriteLine($"{monblan / totalPeople * 100:f2}%");
            Console.WriteLine($"{kilimandjaro / totalPeople * 100:f2}%");
            Console.WriteLine($"{k2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{everest / totalPeople * 100:f2}%");

        }
    }
}
