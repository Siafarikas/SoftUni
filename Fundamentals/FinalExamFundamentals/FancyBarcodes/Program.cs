using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match validBarcode = Regex.Match(barcode, pattern);

                if (validBarcode.Success)
                {
                    string productGroup = string.Empty;
                    bool containsDigit = false;
                    foreach (var character in barcode)
                    {
                        if (char.IsDigit(character))
                        {
                            containsDigit = true;
                            productGroup += character;
                        }

                    }
                    if (containsDigit)
                    {
                        Console.WriteLine($"Product group: {productGroup}");

                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
