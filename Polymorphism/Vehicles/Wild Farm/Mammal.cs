using System;

namespace WildFarm
{
    abstract class Mammal : Animal
    {
        string livingRegion;

        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

        public Mammal(string animalName, double animalWeight, string livingRegion)
            : base(animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight:f2}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
