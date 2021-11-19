using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIDentifiable, IBuyer, IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public int Food { get; set; } = 0;

        public Citizen(string name)
        {
            Name = name;
        }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
