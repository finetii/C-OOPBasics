using System;


namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string animalName, double animalWeight, string livingRegion)
            : base(animalName, animalWeight, livingRegion)
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
                throw new ArgumentException($"Mouses are not eating that type of food");
            }
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}
