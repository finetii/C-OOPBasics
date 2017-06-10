using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                    return "n/a";
                else
                    return this.name;

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                else
                    this.name = value;
            }
        }

        public decimal Money { get; set; }

        public Person()
        {
            this.products = new List<Product>();
        }

        public Person(string name, decimal money)
        {
            this.products = new List<Product>();

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            }
            else
            {
                this.name = name;
            }

            if (money >= 0)
            {
                this.money = money;
            }
            else
            {
                throw new ArgumentException($"{nameof(this.money)} cannot be equal or less than zero");
            }
                
        }


        public Person(string name, decimal money, Product product)
        {
            this.products = new List<Product>();
            this.products.Add(product);

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            }
            else
            {
                this.name = name;
            }

            if (money >= 0)
            {
                this.money = money;
            }
            else
            {
                throw new ArgumentException($"{nameof(this.money)} cannot be equal or less than zero");
            }

        }

        public Person(string name, decimal money, List<Product> products)
        {
            this.products = new List<Product>();
            this.products.AddRange(products);

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            }
            else
            {
                this.name = name;
            }

            if (money >= 0)
            {
                this.money = money;
            }
            else
            {
                throw new ArgumentException($"{nameof(this.money)} cannot be equal or less than zero");
            }

        }

        public bool IsMoneyEnough()
        {
            return (this.products.Sum(p => p.Cost) <= this.money);
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
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
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
                if (value > 0)
                    this.cost = value;
                else
                    throw new Exception($"{nameof(this.cost)} cannot be equal or less than zero");

            }
        }

        public Product(string name, decimal cost)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
            else
                this.name = name;

            if (cost > 0)
                this.cost = cost;
            else
                throw new Exception($"{nameof(this.cost)} cannot be equal or less than zero");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new ShoppingSpree.Person("Fina",100);
            p.Name = "Fina Meranzova";
            p.Name = "";

            Person p1 = new Person("Stoyan", 100, new Product("kniga", 20));
           
        }
    }
}
