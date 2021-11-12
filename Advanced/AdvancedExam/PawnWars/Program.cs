using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] field = new char[8][];

            for (int i = 0; i < field.Length; i++)
            {
                var row = Console.ReadLine().ToCharArray();
                field[i] = row;
            }
            var whiteRow = 0;
            var whiteCol = 0;
            var blackRow = 0;
            var blackCol = 0;
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'w')
                    {
                        whiteRow = i;
                        whiteCol = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'b')
                    {
                        blackRow = i;
                        blackCol = j;
                        break;
                    }
                }
            }
            // found w and b

            char ifWhiteWinsCol = '\0';
            switch (blackCol)
            {
                case 0:
                    ifWhiteWinsCol = 'a';
                    break;
                case 1:
                    ifWhiteWinsCol = 'b';
                    break;
                case 2:
                    ifWhiteWinsCol = 'c';
                    break;
                case 3:
                    ifWhiteWinsCol = 'd';
                    break;
                case 4:
                    ifWhiteWinsCol = 'e';
                    break;
                case 5:
                    ifWhiteWinsCol = 'f';
                    break;
                case 6:
                    ifWhiteWinsCol = 'g';
                    break;
                case 7:
                    ifWhiteWinsCol = 'h';
                    break;
            }
            char ifBlackWinsCol = '\0';
            switch (whiteCol)
            {
                case 0:
                    ifBlackWinsCol = 'a';
                    break;
                case 1:
                    ifBlackWinsCol = 'b';
                    break;
                case 2:
                    ifBlackWinsCol = 'c';
                    break;
                case 3:
                    ifBlackWinsCol = 'd';
                    break;
                case 4:
                    ifBlackWinsCol = 'e';
                    break;
                case 5:
                    ifBlackWinsCol = 'f';
                    break;
                case 6:
                    ifBlackWinsCol = 'g';
                    break;
                case 7:
                    ifBlackWinsCol = 'h';
                    break;
            }

            while (true)
            {
                field[whiteRow][whiteCol] = '-';
                if (whiteCol - 1 >= 0)
                {
                    if (field[whiteRow - 1][whiteCol - 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {ifWhiteWinsCol}{8 - blackRow}.");
                        break;
                    }
                }
                else if (whiteCol + 1 < field.Length)
                {
                    if (field[whiteCol - 1][whiteCol + 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {ifWhiteWinsCol}{8 - blackRow}.");
                        break;
                    }
                }
                whiteRow--;
                if (whiteRow == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {ifBlackWinsCol}8.");
                    break;
                }
                field[whiteRow][whiteCol] = 'w';
                //////////////////////////////////////////////
                ///
                field[blackRow][blackCol] = '-';
                if (blackCol - 1 >= 0)
                {
                    if (field[blackRow + 1][blackCol - 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {ifBlackWinsCol}{8 - whiteRow}.");
                        break;
                    }
                }
                else if (blackCol + 1 < field.Length)
                {
                    if (field[blackRow + 1][blackCol + 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {ifBlackWinsCol}{8 - whiteRow}.");
                        break;
                    }
                }
                blackRow++;
                if (blackRow == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {ifWhiteWinsCol}1.");
                    break;
                }
                field[blackRow][blackCol] = 'b';
            }
        }
    }
}
