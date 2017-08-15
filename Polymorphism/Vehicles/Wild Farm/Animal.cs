

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

        public Animal(string animalName, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
        }

        public virtual string MakeSound()
        {
            return "Silent";
        }
        public virtual void Eat(Food food)
        {
            this.foodEaten += food.Quantity;
        }
    }
}
