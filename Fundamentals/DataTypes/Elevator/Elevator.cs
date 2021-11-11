using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = 0;

            if (n % p == 0)
            {
                courses = n / p;
            }
            else
            {
                courses = n / p + 1;
            }
            if (n <= p)
            {
                Console.WriteLine(courses);
            }
            else
            {
                Console.WriteLine(courses);
            }
        }
    }
}
