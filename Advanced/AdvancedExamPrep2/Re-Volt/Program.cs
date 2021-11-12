using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int commandCount = int.Parse(Console.ReadLine());
            char[][] field = new char[matrixSize][];
            for (int i = 0; i < matrixSize; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                field[i] = row;
            }
            //field done


            //searches for 'f' - player
            var playerRow = 0;
            var playerCol = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                        break;
                    }
                }
            }


            //movements
            for (int i = 0; i < commandCount; i++)
            {
                var movement = Console.ReadLine();
                var oldRow = playerRow;
                var oldCol = playerCol;
                field[playerRow][playerCol] = '-';
                switch (movement)
                {
                    case "up":
                        if (playerRow - 1 >= 0)
                        {
                            playerRow--;
                        }
                        else
                        {
                            playerRow = matrixSize - 1;
                        }
                        if (field[playerRow][playerCol] == 'B')
                        {
                            if (playerRow - 1 <= 0)
                            {
                                playerRow--;
                            }
                            else
                            {
                                playerRow = matrixSize - 1;
                            }
                        }
                        break;
                    case "down":
                        if (playerRow + 1 < matrixSize)
                        {
                            playerRow++;
                        }
                        else
                        {
                            playerRow = 0;
                        }
                        if (field[playerRow][playerCol] == 'B')
                        {
                            if (playerRow + 1 < matrixSize)
                            {
                                playerRow++;
                            }
                            else
                            {
                                playerRow = 0;
                            }
                        }
                        break;
                    case "left":
                        if (playerCol - 1 >= 0)
                        {
                            playerCol--;
                        }
                        else
                        {
                            playerCol = matrixSize - 1;
                        }
                        if (field[playerRow][playerCol] == 'B')
                        {
                            if (playerCol - 1 >= 0)
                            {
                                playerCol--;
                            }
                            else
                            {
                                playerCol = matrixSize - 1;
                            }
                        }
                        break;
                    case "right":
                        if (playerCol + 1 < matrixSize)
                        {
                            playerCol++;
                        }
                        else
                        {
                            playerCol = 0;
                        }
                        if (field[playerRow][playerCol] == 'B')
                        {
                            if (playerCol + 1 < matrixSize)
                            {
                                playerCol++;
                            }
                            else
                            {
                                playerCol = 0;
                            }
                        }
                        break;
                }
                if (field[playerRow][playerCol] == 'T')
                {
                    playerRow = oldRow;
                    playerCol = oldCol;
                    field[playerRow][playerCol] = 'f';
                    continue;
                }
                if (field[playerRow][playerCol] == 'F')
                {
                    break;
                }
                field[playerRow][playerCol] = 'f';
            }
            if ((field[playerRow][playerCol] == 'F'))
            {
                field[playerRow][playerCol] = 'f';
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int i = 0; i < matrixSize; i++)
            {
                Console.WriteLine(new string(field[i]));
            }
        }

    }
}
