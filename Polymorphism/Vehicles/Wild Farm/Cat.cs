
namespace WildFarm
{
    class Cat : Feline
    {
        string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        public Cat(string animalType,string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalType,animalName,animalWeight,livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
