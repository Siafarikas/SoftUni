using System;

namespace Time_15mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hours <= 22)
            {
                if (minutes <= 44)
                {
                    Console.WriteLine($"{hours}:{minutes + 15}");
                }
                else if(minutes < 55)
                {
                    Console.WriteLine($"{hours + 1}:0{(minutes + 15) % 60}");
                }
                else
                {
                    Console.WriteLine($"{hours + 1}:{(minutes + 15) % 60}");
                }

            }
            else if (hours == 23)
            {
                if (minutes <= 44)
                {
                    Console.WriteLine($"{hours}:{minutes + 15}");
                }
                else if (minutes < 55)
                {
                    Console.WriteLine($"0:0{(minutes + 15) % 60}");

                }
                else
                {
                    Console.WriteLine($"0:{(minutes + 15) % 60}");
                }
            }



        }
    }
}
