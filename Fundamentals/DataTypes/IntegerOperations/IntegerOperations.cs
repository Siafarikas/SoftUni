using System;

namespace IntegerOperations
{
    class IntegerOperationsa
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int result = (a + b) * d / c;
            Console.WriteLine(result);
        }
    }
}
