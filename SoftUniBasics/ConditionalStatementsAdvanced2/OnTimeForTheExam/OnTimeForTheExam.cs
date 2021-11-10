using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMins = int.Parse(Console.ReadLine());

            int exHourMins = examHour * 60;
            int arHourMins = arriveHour * 60;

            int exAllMins = exHourMins + examMins;
            int arAllMins = arHourMins + arriveMins;

            string time = "";
            double result = "";

            if (exAllMins - 30 <= arAllMins && arAllMins <= exAllMins)
            {
                time = "On time";
            }
            else if (exAllMins - 30 > arAllMins)
            {
                time = "Early";
            }
            else if (arAllMins >= exAllMins)
            {
                time = "Late";
            }
            if (exAllMins == arAllMins)
            {
                Console.WriteLine("On time");
            }
            else
            {
                if (time == "Early")
                {
                    Console.WriteLine(time);
                    result = exAllMins - arAllMins;

                    if (result <= 59)
                    {
                        Console.WriteLine($"{result} minutes before the start");

                    }
                }
            }

        }
    }
}
