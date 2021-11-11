using System;

namespace AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubractsThirdNumFromSum(num1, num2, num3)); 
        }

        static int SumOfFirst2Nums(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int SubractsThirdNumFromSum(int num1, int num2, int num3)
        {
            int result = SumOfFirst2Nums(num1, num2) - num3;
            return result;
        }
    }
}
