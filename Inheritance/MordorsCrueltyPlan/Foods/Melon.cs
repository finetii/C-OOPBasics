
namespace MordorsCrueltyPlan
{
    class Melon : Food
    {
        private const int _pointsOfHappiness = 1;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Melon()
            :base(_pointsOfHappiness)
        {
        }
    }
}
