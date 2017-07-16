
namespace MordorsCrueltyPlan
{
    class Cram : Food
    {
        private const int _pointsOfHappiness = 2;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Cram()
            :base(_pointsOfHappiness)
        {
        } 
    }
}
