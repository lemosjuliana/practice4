namespace Practice4
{
    public class Cycling : Activity
    {
        private float _speed;
        public Cycling()
        {

        }
        public void SetSpeed(int speed)
        {
            _speed = speed;
        }

        public override float GetSpeed()
        {
            return _speed;
        }
    }
}