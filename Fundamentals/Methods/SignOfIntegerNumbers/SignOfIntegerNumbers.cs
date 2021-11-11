using System;

namespace SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            Sign(int.Parse(Console.ReadLine()));
        }

        static void Sign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");

            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
          
    }
}
