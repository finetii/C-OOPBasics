
namespace MordorsCrueltyPlan
{
    class HoneyCake : Food
    {
        private const int _pointsOfHappiness = 5;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public HoneyCake()
            :base(_pointsOfHappiness)
        {
        }
    }
}
