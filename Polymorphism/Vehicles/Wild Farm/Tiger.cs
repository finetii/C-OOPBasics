using System;


namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger(string animalType,string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName,animalWeight,livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten = food.Quantity;
            }
            else
            {
                throw new Exception($"Tigers are not eating that type of food!");
            }
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }
    }
}

