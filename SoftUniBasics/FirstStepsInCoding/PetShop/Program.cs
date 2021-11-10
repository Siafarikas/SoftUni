using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double finalSum = (dogs * 2.50) + (otherAnimals * 4);
            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
