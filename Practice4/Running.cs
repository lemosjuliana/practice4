namespace Practice4
{
    public class Running : Activity
    {
        private int _distance;

        public Running()
        {

        }
        public void SetDistance(int km)
        {
            _distance = km;
        }
        public override float GetDistance()
        {
            return _distance;
        }
        public override float GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60f;
        }
    }
}