using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double land = double.Parse(Console.ReadLine());
            double discount = (land * 7.61 * 0.18);
            double finalPrice = (land * 7.61) - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv,");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
