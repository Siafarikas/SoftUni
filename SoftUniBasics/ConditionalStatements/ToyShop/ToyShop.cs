using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double vacPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalMoney = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            int toys = puzzles + dolls + bears + minions + trucks;

            if (toys >= 50)
            {
                totalMoney -= totalMoney * 0.25;
            }
                totalMoney -= totalMoney * 0.10;
            if (totalMoney >= vacPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - vacPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacPrice - totalMoney:f2} lv needed.");
            }

        }
    }
}