using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Bird : Animal
    {
        public double WingSize { get; set; }
        public Bird(string name, double weight, double wingSize)
            :base(name, weight)
        {
            WingSize = wingSize;
        }

    }
}
