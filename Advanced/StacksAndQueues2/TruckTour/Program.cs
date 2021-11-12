using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<int[]> tour = new Queue<int[]>(pumps);

            for (int i = 0; i < pumps; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                tour.Enqueue(petrolPump);
            }

            int startIdx = 0;
            while (true)
            {
                if (tour.Count == 0)
                {
                    break;
                }
                int fuelTank = 0;
                foreach (var petrolPum in tour)
                {
                    int refuelAmount = petrolPum[0];
                    int distance = petrolPum[1];

                    fuelTank += refuelAmount - distance;
                    if (fuelTank < 0)
                    {
                        tour.Enqueue(tour.Dequeue());
                        startIdx++;
                        break;
                    }
                }
                if (fuelTank >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(startIdx);
        }
    }
}
