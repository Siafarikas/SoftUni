using System;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divider = 0;
            if (num % 10 == 0)
            {
                divider = 10;
            }
            else if (num % 7 == 0)
            {
                divider = 7;
            }
            else if (num % 6 == 0)
            {
                divider = 6;
            }
            else if (num % 3 == 0)
            {
                divider = 3;
            }
            else if (num % 2 == 0)
            {
                divider = 2;
            }
            if (divider != 0)
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
