using System;


namespace WildFarm
{
    class Cat : Felime
    {
        string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        public Cat(string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalName,animalWeight,livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }
    }
}
