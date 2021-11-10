using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakeSize = width * length;
            string input = "";
            int cakePieces = 0;

            while (input != "STOP" && !(cakePieces >= cakeSize))
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize - cakePieces} pieces are left.");
                    break;
                }

                cakePieces += int.Parse(input);
                if (cakeSize < cakePieces)
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces - cakeSize} pieces more.");
                    break;
                }
            }
        }
    }
}
