using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = LineDistance(x1, y1, x2, y2);
            double secondLine = LineDistance(x3, y3, x4, y4);

            if (secondLine > firstLine)
            {
                if (CalculatesDistanceToThePoint(x3, y3) > CalculatesDistanceToThePoint(x4, y4))
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");

                }
            }
            else
            {
                if (CalculatesDistanceToThePoint(x1, y1) > CalculatesDistanceToThePoint(x2, y2))
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
        }

        static double CalculatesDistanceToThePoint(double x, double y)
        {
            double c = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt(c);
            return result;
        }

        static double LineDistance(double x1, double y1, double x2, double y2)
        {
            double line = Math.Sqrt(Math.Abs((Math.Pow(x1 - x2, 2)) + Math.Pow(y1 - y2, 2)));

            return line;
        }
    }
}
