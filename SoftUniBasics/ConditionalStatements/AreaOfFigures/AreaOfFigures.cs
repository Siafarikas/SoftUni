using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideSquare = double.Parse(Console.ReadLine());
                double areaSquare = sideSquare * sideSquare;
                Console.WriteLine($"{areaSquare:f3}");
            }
            if (figure == "rectangle")
            {
                double sideRectA = double.Parse(Console.ReadLine());
                double sideRectB = double.Parse(Console.ReadLine());
                double areaRect = sideRectA * sideRectB;
                Console.WriteLine($"{areaRect:f3}");

            }
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaCircle = radius * radius * Math.PI;
                Console.WriteLine($"{areaCircle:f3}");

            }
            if (figure == "triangle")
            {
                double sideTriangle = double.Parse(Console.ReadLine());
                double heightToSide = double.Parse(Console.ReadLine());
                double areaTriangle = sideTriangle * heightToSide / 2;
                Console.WriteLine($"{areaTriangle:f3}");
            }
        }
    }
}
