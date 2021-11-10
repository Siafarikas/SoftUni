using System;

namespace RoomPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintCans = int.Parse(Console.ReadLine());
            int tapeti = int.Parse(Console.ReadLine());
            double priceGloves = double.Parse(Console.ReadLine());
            double priceBrush = double.Parse(Console.ReadLine());

            double totalMoney = (paintCans * 21.50 + tapeti * 5.20) + (Math.Ceiling(tapeti * 0.35)) * priceGloves + (Math.Floor(paintCans * 0.48)) * priceBrush;
            double deliveryCost = totalMoney / 15;

            Console.WriteLine($"This delivery will cost {deliveryCost:f2} lv.");

        }
    }
}
