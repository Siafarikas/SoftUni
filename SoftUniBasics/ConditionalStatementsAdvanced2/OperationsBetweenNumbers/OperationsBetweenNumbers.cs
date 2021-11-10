using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            string number = "";

            switch (operation)
            {
                case "+":
                    result = N1 + N2;
                    if (result % 2 == 0)
                    {
                        number = "even";
                    }
                    else
                    {
                        number = "odd";
                    }
                    Console.WriteLine($"{N1} + {N2} = {result} - {number}");
                    break;
                case "-":
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        number = "even";
                    }
                    else
                    {
                        number = "odd";
                    }
                    Console.WriteLine($"{N1} - {N2} = {result} - {number}");
                    break;
                case "*":
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        number = "even";
                    }
                    else
                    {
                        number = "odd";
                    }
                    Console.WriteLine($"{N1} * {N2} = {result} - {number}");
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 / N2;
                        Console.WriteLine($"{N1} / {N2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result}");
                    }
                    break;

                default:
                    break;
            }

        }
    }
}
