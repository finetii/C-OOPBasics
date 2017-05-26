using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    class Animal
    {
        public string name;
        public string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public override string ToString()
        {
            return $"{name} {breed}";
        }
    }

    class AnimalClinic
    {
        static int patientId;
        static int healedAnimalsCount;
        static int rehabilitedAnimalsCount;
        static List<Animal> healed = new List<Animal>();
        static List<Animal> rehabilitated = new List<Animal>();
        public static int HealedAnimalsCount
        {
            get
            {
                return healedAnimalsCount;
            }
        }
        public static int RehabilitatedCount
        {
            get
            {
                return rehabilitedAnimalsCount;
            }
        }
        public static void Heal(Animal a)
        {
            healed.Add(a);
            patientId++;
            healedAnimalsCount++;
            Console.WriteLine($"Patient {patientId}: [{a.name} ({a.breed})] has been healed!"); 
        }
        public static void Rehabilitate(Animal a)
        {
            rehabilitated.Add(a);
            patientId++;
            rehabilitedAnimalsCount++;
            Console.WriteLine($"Patient {patientId}: [{a.name} ({a.breed})] has been rehabilitated!");
        }
        private AnimalClinic() { }
        
        
        public static void Total(string s)
        {
            switch(s)
            {
                case "heal":
                    foreach (var a in healed)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                case "rehabilitate":
                    foreach (var a in rehabilitated)
                    {
                        Console.WriteLine(a);
                    }
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while(command != "End")
            {
                string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = new Animal(input[0], input[1]);
                switch(input[2])
                {
                    case "heal":
                        AnimalClinic.Heal(animal);
                        break;
                    case "rehabilitate":
                        AnimalClinic.Rehabilitate(animal);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount}" + Environment.NewLine + $"Total rehabilitated animals: {AnimalClinic.RehabilitatedCount}");
            AnimalClinic.Total(Console.ReadLine());
        }
    }
}
