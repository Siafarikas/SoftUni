using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litresFull = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                litresFull += litres;
                if (litresFull <= 255)
                {
                    continue;
                }
                else
                {
                    litresFull -= litres;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litresFull);
        }
    }
}
