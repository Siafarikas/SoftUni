using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            double standardT = 0;
            double kidT = 0;
            double studentT = 0;


            while (movie != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                int tickets = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    tickets++;
                    switch (ticketType)
                    {
                        case "standard":
                            standardT++;
                            break;
                        case "kid":
                            kidT++;
                            break;
                        case "student":
                            studentT++;
                            break;
                    }
                    if (tickets == seats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                totalTickets += tickets;

                double percentFull = tickets * 1.0 / seats * 100;
                Console.WriteLine($"{movie} - {percentFull:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentT / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardT / totalTickets * 100:f2} standard tickets.");
            Console.WriteLine($"{kidT / totalTickets * 100:f2} kids tickets.");
        }
    }
}
