using System;

namespace BattleOfFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                field[i] = row;
            }

            var heroRow = 0;
            var heroCol = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'A')
                    {
                        heroRow = i;
                        heroCol = j;
                        break;
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine();
                var commandParts = command.Split();
                var armyMovement = commandParts[0];
                var orcX = int.Parse(commandParts[1]);
                var orcY = int.Parse(commandParts[2]);

                armor--;
                field[orcX][orcY] = 'O';
                field[heroRow][heroCol] = '-';
                if (armyMovement == "up" && heroRow - 1 >= 0)
                {
                    heroRow--;
                }
                else if (armyMovement == "down" && heroRow + 1 < rows)
                {
                    heroRow++;
                }
                else if (armyMovement == "left" && heroCol - 1 >= 0)
                {
                    heroCol--;
                }
                else if (armyMovement == "right" && heroCol + 1 < field[heroRow].Length)
                {
                    heroCol++;
                }

                if (field[heroRow][heroCol] == 'O')
                {
                    armor -= 2;
                }

                if (field[heroRow][heroCol] == 'M')
                {
                    field[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                if (armor <= 0)
                {
                    field[heroRow][heroCol] = 'X';
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    break;
                }
                field[heroRow][heroCol] = 'A';
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(field[i]));
            }

        }
    }
}
