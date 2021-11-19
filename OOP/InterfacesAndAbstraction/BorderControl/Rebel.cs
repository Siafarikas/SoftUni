using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer, IIDentifiable, IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; } = 0;
        public string Id { get; set; }

        public Rebel(string name)
        {
            Name = name;
        }
        public void BuyFood()
        {
            this.Food += 5;
        }

    }
}
