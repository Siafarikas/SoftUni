using System;

namespace AgencyProfit
{
    class AgencyProfit
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double priceAdultTicket = double.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());

            double income = (adultTickets * (priceAdultTicket + taxPrice) + kidTickets * ((priceAdultTicket - priceAdultTicket * 0.70) + taxPrice));
            double winnings = income * 0.20;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {winnings:f2} lv.");
        }
    }
}
