using System;
using System.Collections.Generic;


namespace MordorsCrueltyPlan
{
    using Moods;
    using Foods;
    class Gandalf
    {
        private int happinessPoints;

        public Mood GetHappineess()
        {
            return MoodFactory.GetMood(this.happinessPoints);
        }

        public void Eat(IEnumerable<Food> foods)
        {
            foreach (Food food in foods)
            {
                this.happinessPoints += food.PointsOfHappiness;
            }
        }

        public override string ToString()
        {
            Mood mood = GetHappineess();
            return $"{this.happinessPoints}{Environment.NewLine}{mood.GetType().Name}";
        }
    }
}
