using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (CalculatesDistanceToThePoint(x1, y1) > CalculatesDistanceToThePoint(x2, y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }

        }

        static double CalculatesDistanceToThePoint(double x, double y)
        {
            double c = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(c);
            return result;
        }
    }
}
