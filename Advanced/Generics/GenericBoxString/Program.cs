using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(double.Parse(input));
            }
            Box<double> box = new Box<double>(list);
            double elementToCompare = double.Parse(Console.ReadLine());
            int count = box.Count(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
