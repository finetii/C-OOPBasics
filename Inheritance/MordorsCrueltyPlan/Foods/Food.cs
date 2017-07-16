
namespace MordorsCrueltyPlan
{
    class Food
    {
        public virtual int PointsOfHappiness { get; private set; }

        public Food(int pointsOfHappiness)
        {
            this.PointsOfHappiness = pointsOfHappiness;
        }
    }
}
