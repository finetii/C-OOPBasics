
namespace MordorsCrueltyPlan
{
    class Apple : Food
    {
        private const int _pointsOfHappiness = 1;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Apple()
            : base (_pointsOfHappiness)
        {
        }
    }
}
