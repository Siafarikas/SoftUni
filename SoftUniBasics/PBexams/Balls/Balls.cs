using System;

namespace Balls
{
    class Balls
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int otherBalls = 0;
            int timesDividedByBlackBalls = 0;

            for (int i = 1; i <= numberOfBalls; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        redBalls++;
                        totalPoints += 5;
                        break;
                    case "orange":
                        orangeBalls++;
                        totalPoints += 10;
                        break;
                    case "yellow":
                        yellowBalls++;
                        totalPoints += 15;
                        break;
                    case "white":
                        whiteBalls++;
                        totalPoints += 20;
                        break;
                    case "black":
                        timesDividedByBlackBalls++;
                        totalPoints = totalPoints / 2;
                        break;
                    default:
                        otherBalls++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redBalls}");
            Console.WriteLine($"Points from orange balls: {orangeBalls}");
            Console.WriteLine($"Points from yellow balls: {yellowBalls}");
            Console.WriteLine($"Points from white balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherBalls}");
            Console.WriteLine($"Divides from black balls: {timesDividedByBlackBalls}");
        }
    }
}
