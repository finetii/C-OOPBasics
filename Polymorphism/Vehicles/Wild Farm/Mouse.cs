using System;


namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string animalType,string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                this.FoodEaten = food.Quantity;
            }
            else
            {
                throw new Exception($"Mice are not eating that type of food!");
            }
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}
