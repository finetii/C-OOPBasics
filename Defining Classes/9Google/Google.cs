using System;
using System.Collections.Generic;
using System.Linq;

namespace _9Google
{
    public class Person
    {
        public string name;
        public Company company;
        public List<Pokemon> pokemons;
        public List<Parents> parents;
        public List<Children> children;
        public Car car;       

        public Person(string name)
        {
            this.name = name;
            this.pokemons = new List<Pokemon>();
            this.children = new List<Children>();
            this.parents = new List<Parents>();
        }
        
        public override string ToString()
        {
            string output = $"{name}\nCompany: {(company != null ? "\n" + company.ToString() : "")}\nCar: {(car != null ? "\n" + car.ToString() : "")}\nPokemon:";
            foreach(var p in pokemons)
            {
                output += (p != null ? "\n" + p.ToString() : "");
            }
            output += "\n" + "Parents:";
            foreach (var parent in parents)
            {
                output += (parent != null ? "\n" + parent.ToString() : "");
            }
            output += "\n" + "Children:";
            foreach (var child in children)
            {
                output += (child != null ? "\n" + child.ToString() : "");
            }            
            return output;
        }
    }
    public class Car
    {
        public string model;
        public int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public override string ToString()
        {
            return $"{model} {speed}";
        }
    }

    public class Children
    {
        public string name;
        public string birthday;

        public Children(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return $"{name} {birthday}";
        }
    }

    public class Parents
    {
        public string name;
        public string birthday;

        public Parents(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return $"{name} {birthday}";
        }
    }

    public class Company
    {
        public string name;
        public string department;
        public decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public override string ToString()
        {
            //string sal = string.Format("{0:0.00", salary);
            return $"{name} {department} {salary:f2}";
        }
    }

    public class Pokemon
    {
        public string name;
        public string type;        

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public override string ToString()
        {
            return $"{name} {type}";
        }
    }
    
    public class Google
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] personDetails =command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(!persons.Any(p=>p.name == personDetails[0]))
                {
                    persons.Add(new Person(personDetails[0]));
                }

                Person person = persons.FirstOrDefault(p => p.name == personDetails[0]);

                switch(personDetails[1])
                {
                    case "company":
                        person.company = new Company(personDetails[2], personDetails[3], decimal.Parse(personDetails[4]));
                        break;
                    case "car":
                        person.car = new Car(personDetails[2], int.Parse(personDetails[3]));
                        break;
                    case "parents":
                        person.parents.Add(new Parents(personDetails[2], personDetails[3]));
                        break;
                    case "children":
                        person.children.Add(new Children(personDetails[2], personDetails[3]));
                        break;
                    case "pokemon":
                        person.pokemons.Add(new Pokemon(personDetails[2], personDetails[3]));
                        break;
                }
                
                /*
                if (personDetails[1] == "company")
                {
                    person.company = new Company(personDetails[2], personDetails[3], decimal.Parse(personDetails[4]));
                }
                if (personDetails[1] == "car")
                {
                    person.car = new Car(personDetails[2], int.Parse(personDetails[3]));
                }
                if (personDetails[1] == "parents")
                {
                    person.parents.Add(new Parents(personDetails[2], DateTime.Parse(personDetails[3])));
                }
                if (personDetails[1] == "children")
                {
                    person.children.Add(new Children(personDetails[2], DateTime.Parse(personDetails[3])));
                }
                if (personDetails[1] == "pokemon")
                {
                    person.pokemons.Add(new Pokemon(personDetails[2], personDetails[3]));
                }//*/

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            
           foreach(var person in persons)
            {
                if (person.name == command)
                {
                    Console.WriteLine(person.ToString());
                }
            }         
        }
    }
}
