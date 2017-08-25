
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

        public Mammal(string animalType,string animalName, double animalWeight, string livingRegion)
            : base(animalType,animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
