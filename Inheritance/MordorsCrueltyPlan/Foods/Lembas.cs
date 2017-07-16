
namespace MordorsCrueltyPlan
{
    class Lembas : Food
    {
        private const int _pointsOfHappiness = 3;

        public override int PointsOfHappiness
        {
            get
            {
                return _pointsOfHappiness;
            }
        }

        public Lembas()
            :base(_pointsOfHappiness)
        {
        }
    }
}
