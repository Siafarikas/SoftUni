using System;

namespace CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(width, height)); 
        }

        static int Calculation(int width, int height)
        {
            int result = width * height;
            return result;
        }
    }
}
