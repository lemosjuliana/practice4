namespace Practice4
{
    public class Swimming : Activity
    {
        private int _laps;
        private float _meters;

        public Swimming()
        {
            _meters = 50.00f;
        }
        public override float GetDistance()
        {
            return (GetLaps() * _meter) / 1000;
        }

        public override float GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60;
        }
        public void SetLaps(float laps)
        {
            _laps = laps;
        }
        public float GetLaps()
        {
            return _laps;
        }
    }

}