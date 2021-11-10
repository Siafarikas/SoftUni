using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double moneyEarnedPerChef = (cakes * 45 + waffles * 5.80 + pancakes * 3.20) * days;
            double totalMoneyEarned = moneyEarnedPerChef * chefs;
            double moneyEarnedAfterExpanses = totalMoneyEarned - totalMoneyEarned / 8;
            Console.WriteLine(moneyEarnedAfterExpanses);


        }
    }
}
