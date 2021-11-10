using System;

namespace CinemaTicket
{
    class CinemaTicket
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine("12");
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine(12);
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine(14);
            }
            else if (day == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (day == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "Saturday")
            {
                Console.WriteLine(16);
            }
            else if (day == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
