using System;

namespace PizzaCalories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private readonly double baseCalloriesPerGram = 2;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                    this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                    this.bakingTechnique = value;
            }
        }
        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                else
                    this.weight = value;
            }
        }
        public double Calories()
        {
            double modifierFlour = 0;
            double modifierBaking = 0;
            switch (this.FlourType.ToLower())
            {
                case "white": modifierFlour = 1.5; break;
                case "wholegrain": modifierFlour = 1; break;
            }
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy": modifierBaking = 0.9; break;
                case "chewy": modifierBaking = 1.1; break;
                case "homemade": modifierBaking = 1; break;
            }


            return (baseCalloriesPerGram * this.Weight) * modifierFlour * modifierBaking;
        }
    }
}
