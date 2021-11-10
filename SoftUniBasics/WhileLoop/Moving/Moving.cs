using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int boxes = 0;
            int apartmentSpace = width * length * height;

            while (input != "Done" && !(boxes > apartmentSpace))
            {
                int spaceTaken = int.Parse(input);
                boxes += spaceTaken;
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{apartmentSpace - boxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes - apartmentSpace} Cubic meters more.");
            }
        }
    }
}
