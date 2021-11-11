using System;

namespace DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(DataType(value));
            }
            else if (input == "real")
            {
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine($"{DataType(value):f2}");

            }
            else
            {
                string value = Console.ReadLine();
                Console.WriteLine($"${value}$");
            }
        }

        static int DataType(int number)
        {
            int result = number * 2;
            return result;
        }

        static double DataType(double number)
        {
            double result = number * 1.5;
            return result;
        }

        static string DataType(string text)
        {
            string result = $"${text}$";
            return result;
        }
    }
}
