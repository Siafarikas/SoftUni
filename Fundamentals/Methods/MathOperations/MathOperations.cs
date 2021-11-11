using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(firstNum, operation, secondNum));
        }
        static double Calculation(int firstNum, string operation, int secondNum)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
            }
            return result;
        }
    }
}
