using System;
using System.Collections.Generic;


namespace WildFarm
{
    class Program
    {
        private static List<Animal> InitAnimals(string command)
        {
            List<Animal> animals = new List<Animal>();
            try
            {
                    string[] animalData = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string animalType = animalData[0];
                    string animalName = animalData[1];
                    double.TryParse(animalData[2], out double animalWeight);
                    string livingRegion = animalData[3];

                switch (animalType)
                {
                    case "Cat":
                        string breed = animalData[4];
                        Animal cat = new Cat(animalType, animalName, animalWeight, livingRegion, breed);
                        animals.Add(cat);
                        break;
                    case "Zebra":
                        Animal zebra = new Zebra(animalType, animalName, animalWeight, livingRegion);
                        animals.Add(zebra);
                        break;
                    case "Mouse":
                        Animal mouse = new Mouse(animalType, animalName, animalWeight, livingRegion);
                        animals.Add(mouse);
                        break;
                    case "Tiger":
                        Animal tiger = new Tiger(animalType, animalName, animalWeight, livingRegion);
                        animals.Add(tiger);
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return animals;
        }

        private static Food InitFood(string command, Food food)
        {
            try
            {
                string[] foodData = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodData[0];
                int.TryParse(foodData[1], out int foodQty);

                switch (foodType)
                {
                    case "Meat":                        
                            food = new Meat(foodQty);
                        break;
                    case "Vegetable":
                            food = new Vegetable(foodQty);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return food;
        }
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Food food = null;

            string command = Console.ReadLine();
            try
            {
                while(command != "End")
                {
                    animals = InitAnimals(command);
                    command = Console.ReadLine();
                    food = InitFood(command,food);
                    foreach (var animal in animals)
                    {
                        try
                        {
                            animal.Eat(food);
                            Console.WriteLine(animal.MakeSound());
                            Console.WriteLine(animal);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(animal.MakeSound());
                            Console.WriteLine(e.Message);
                            Console.WriteLine(animal);
                        }
                    }
                    command = Console.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
