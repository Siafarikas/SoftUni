using System;

namespace ChangeBureau
{
    class ChangeBureau
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chinese = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            double euros = (((bitcoins * 1168) / 1.95) + ((chinese * 0.15) * 1.76) / 1.95);
            euros = euros - euros * comission / 100;
            Console.WriteLine($"{euros:f2}");

        }
    }
}
