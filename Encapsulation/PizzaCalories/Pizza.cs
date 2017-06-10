using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, int num)
        {
            this.Name = name;
            if(num > 10 || num < 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                else
                    this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }
        public void AddTopping(Topping t)
        {
            toppings.Add(t);            
        }
        public double CalculateCalories()
        {
            double ttotal = 0;
            foreach(var t in toppings)
            {
                ttotal += t.Calories();
            }
            return this.Dough.Calories() + ttotal; 
        }
    }
}
