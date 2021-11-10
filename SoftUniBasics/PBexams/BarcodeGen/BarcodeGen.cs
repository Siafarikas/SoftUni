using System;

namespace BarcodeGen
{
    class BarcodeGen
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int digit1F = firstNum % 10;
            int digit2F = firstNum / 10 % 10;
            int digit3F = firstNum / 100 % 10;
            int digit4F = firstNum / 1000 % 10;
            int digit1S = secondNum % 10;
            int digit2S = secondNum / 10 % 10;
            int digit3S = secondNum / 100 % 10;
            int digit4S = secondNum / 1000 % 10;


            for (int i = digit4F; i <= digit4S; i++)
            {
                for (int j = digit3F; j <= digit3S; j++)
                {
                    for (int k = digit2F; k <= digit2S; k++)
                    {
                        for (int l = digit1F; l <= digit1S; l++)
                        {
                            if (i % 2 == 1 && j % 2 == 1 && k % 2 == 1 && l % 2 == 1)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
