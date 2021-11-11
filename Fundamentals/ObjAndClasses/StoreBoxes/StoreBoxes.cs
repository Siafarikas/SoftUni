using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class StoreBoxes
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split();
                string serialNum = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box();
                box.SerialNumber = serialNum;
                box.ItemName = itemName;
                box.ItemPrice = itemPrice;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = itemQuantity * itemPrice;
                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(i => i.PriceForBox).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }


    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}
