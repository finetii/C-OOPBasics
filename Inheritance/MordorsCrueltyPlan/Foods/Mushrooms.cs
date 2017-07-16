

namespace MordorsCrueltyPlan.Foods
{
    class Mushrooms : Food
    {
        private const int _pointsOfHappiness = -10;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Mushrooms()
            :base(_pointsOfHappiness)
        {
        }
    }
}
