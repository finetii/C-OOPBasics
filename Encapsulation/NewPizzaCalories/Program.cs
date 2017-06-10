using System;
using System.Collections.Generic;


namespace _05.Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private const double baseCalloriesPerGram = 2;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            get
            {
                return this.flourType;
            }

            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double Callories()
        {
            double modifier = baseCalloriesPerGram;
            switch (this.FlourType.ToLower())
            {
                case "white": modifier *= 1.5; break;
                case "wholegrain": modifier *= 1.0; break;
            }

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy": modifier *= 0.9; break;
                case "chewy": modifier *= 1.1; break;
                case "homemade": modifier *= 1.0; break;
            }

            return modifier * this.Weight;
        }
    }
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value == string.Empty || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            private get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }

        public int GetNumberOfToppings()
        {
            return this.toppings.Count;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public double Callories()
        {
            double callories = 0;
            callories += this.dough.Callories();
            foreach (Topping topping in this.toppings)
            {
                callories += topping.Callories();
            }

            return callories;
        }
    }
    public class Topping
    {
        private string type;
        private int weight;
        private const int baseCalloriesPerGram = 2;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "sauce" && value.ToLower() != "cheese")
                {
                    throw new ArgumentException(string.Format("Cannot place {0} on top of your pizza.", value));
                }
                this.type = value;
            }
        }

        private int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format("{0} weight should be in the range [1..50].", this.Type));
                }
                this.weight = value;
            }
        }

        public double Callories()
        {
            double modifier = baseCalloriesPerGram;

            switch (this.Type.ToLower())
            {
                case "meat": modifier *= 1.2; break;
                case "veggies": modifier *= 0.8; break;
                case "cheese": modifier *= 1.1; break;
                case "sauce": modifier *= 0.9; break;
            }

            return modifier * this.Weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Dough")
                {
                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        Console.WriteLine("{0:f2}", dough.Callories());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else if (tokens[0] == "Topping")
                {
                    try
                    {
                        Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                        Console.WriteLine("{0:f2}", topping.Callories());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else
                {
                    string name = tokens[1];
                    int numberOfToppings = 0;
                    numberOfToppings = int.Parse(tokens[2]);
                    if (numberOfToppings > 10)
                    {
                        Console.WriteLine("Number of toppings should be in range [0..10].");
                        return;
                    }

                    command = Console.ReadLine();
                    tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    Pizza pizza;
                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        pizza = new Pizza(name, dough);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    for (int i = 0; i < numberOfToppings; i++)
                    {
                        command = Console.ReadLine();
                        tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                            pizza.AddTopping(topping);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }
                    Console.WriteLine("{0} - {1:F2} Calories.", pizza.Name, pizza.Callories());
                    return;
                }
                command = Console.ReadLine();
            }
        }
    }
}