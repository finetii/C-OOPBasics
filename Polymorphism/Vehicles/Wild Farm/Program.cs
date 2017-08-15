using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] animalData = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string animalType = animalData[0];
                string animalName = animalData[1];
                double.TryParse(animalData[2], out double animalWeight);
                string livingRegion = animalData[3];
                string[] foodData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodData[0];
                int.TryParse(foodData[1], out int foodQty);
                if (foodType == "Vegetable")
                {
                    Food food = new Vegetable(foodQty);
                }
                else
                    Food food = new Meat(foodQty);

                switch (animalType)
                {
                    case "Cat":
                        try
                        {
                            string breed = animalData[4];
                            Animal cat = new Cat(animalName, animalWeight, livingRegion, breed);
                            cat.Eat(food);
                            Console.WriteLine(cat.MakeSound());
                            Console.WriteLine(cat.ToString());
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
