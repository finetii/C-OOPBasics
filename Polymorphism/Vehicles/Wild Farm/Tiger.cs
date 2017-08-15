using System;


namespace WildFarm
{
    class Tiger : Felime
    {
        public Tiger(string animalName, double animalWeight, string livingRegion)
            : base(animalName,animalWeight,livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.Equals("Meat"))
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Tigers are not eating that type of food");
            }
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }
    }
}
}
