using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightCount = int.Parse(Console.ReadLine());

            Queue<string> trafficLine = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (input == "green")
                {
                    for (int i = 0; i < greenLightCount; i++)
                    {
                        if (trafficLine.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{trafficLine.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    trafficLine.Enqueue(input);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
