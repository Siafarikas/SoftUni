using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Food : IFood
    {
        public int Quantity { get; protected set; }


        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
