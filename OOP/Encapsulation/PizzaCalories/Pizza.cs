using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (!(value == string.Empty) && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }
        public int CountOfToppings => this.toppings.Count;
        public List<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

       


        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public double TotalCalories => CalculateTotalCalories();

        private double CalculateTotalCalories()
        {
            double doughCalories = this.Dough.DoughCalories();
            double toppingCalories = 0.0;
            foreach (Topping topping in this.Toppings)
            {
                toppingCalories += topping.ToppingCalories();
            }

            return doughCalories + toppingCalories;
        }
    }
}
