

namespace WildFarm
{
    abstract class Animal
    {
        string animalName;
        string animalType;
        double animalWeight;
        int foodEaten;

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        
        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }

        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public Animal(string animalType, string animalName, double animalWeight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
        }

        public abstract string MakeSound();
        public virtual void Eat(Food food)
        {
            this.FoodEaten = food.Quantity;
        }
    }
}
