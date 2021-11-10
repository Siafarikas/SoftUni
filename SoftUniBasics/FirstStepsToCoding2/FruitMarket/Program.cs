using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasKilos = double.Parse(Console.ReadLine());
            double orangesKilos = double.Parse(Console.ReadLine());
            double berriesKilos = double.Parse(Console.ReadLine());
            double strawberriesKilos = double.Parse(Console.ReadLine());

            double berriesPrice = strawberriesPrice / 2;
            double orangesPrice = berriesPrice - berriesPrice * 0.40;
            double bananasPrice = berriesPrice - berriesPrice * 0.80;

            double moneyNeeded = strawberriesKilos * strawberriesPrice + bananasKilos * bananasPrice + berriesKilos * berriesPrice + orangesKilos * orangesPrice;
            Console.WriteLine($"{moneyNeeded:f2}");

        }
    }
}
