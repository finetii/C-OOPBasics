using System;


namespace WildFarm
{
    class Zebra : Mammal
    {
        public Zebra(string animalName, double animalWeight, string livingRegion)
            : base(animalName,animalWeight,livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.Equals("Vegetable"))
            {
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"Zebras are not eating that type of food");
            }
        }

        public override string MakeSound()
        {
            return "Zs";
        }
    }
}
