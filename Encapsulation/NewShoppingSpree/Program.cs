using System;
using System.Collections.Generic;
using System.Linq;

namespace NewShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> shoppingBag;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                    this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                    this.money = value;
            }
        }
        public Person(string name, decimal money)
        {
            this.Name = name;
            try
            {
                this.Money = money;
            }
            catch(ArgumentException ae)
            {
                throw ae;
            }
            this.shoppingBag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");

            }
            else
            { 
                this.Money -= product.Cost;
                shoppingBag.Add(product);
            }
        }
        public override string ToString()
        {
            string products = string.Join(", ", this.shoppingBag);
            if (string.IsNullOrEmpty(products))
            {
                products = "Nothing bought";
            }

            string result = $"{this.Name} - {products}";
            return result;
        }
    }

    class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                    this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                    this.cost = value;
            }
        }
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] personInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                persons = InitialisePeople(personInput);
                products = InitialiseProducts(productInput);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }    
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] newInput = command.Split(' ');
                string personName = newInput[0];
                string productName = newInput[1];
                Person person = persons.Where(p => p.Name == personName).FirstOrDefault();
                Product product = products.Where(p => p.Name == productName).FirstOrDefault();
                try
                {
                    person.BuyProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch(InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                command = Console.ReadLine();
            }
            foreach(Person person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static List<Person>InitialisePeople(string[] input)
        {
            List<Person> persons = new List<Person>();
            foreach (var item in input)
            {
                string[] peopleInput = item.Split('=');
                string name = peopleInput[0].Trim();
                decimal money = decimal.Parse(peopleInput[1].Trim());
                try
                {
                    persons.Add(new Person(name, money));                    
                }
                catch (ArgumentException ae)
                {
                    throw ae;
                }
            }
            return persons;
        }

        private static List<Product> InitialiseProducts(string[] input)
        {
            List<Product> products = new List<Product>();
            foreach (var item in input)
            {
                string[] productsInput = item.Split('=');
                string name = productsInput[0].Trim();
                decimal cost = decimal.Parse(productsInput[1].Trim());
                try
                {
                    products.Add(new Product(name, cost));
                }
                catch (ArgumentException ae)
                {
                    throw ae;
                }                
            }
            return products;
        }

    }
}
