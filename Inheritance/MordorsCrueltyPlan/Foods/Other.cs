
namespace MordorsCrueltyPlan.Foods
{
    class Other : Food
    {
        private const int _pointsOfHappiness = -1;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Other()
            :base(_pointsOfHappiness)
        {
        }
    }
}
