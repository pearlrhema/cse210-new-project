public class Cycling:Activity
{
    private double _speed;

        public Cycling(string date, double length, double speed, float minutes) : base(date, length, minutes)
        {
            _speed = speed;
            _date = date;
            _length = length;
            _minutes = minutes;
        }

        protected override double CalculateDistance()
        {
            double distance = _speed * (_length / 60);
            return distance;
        }

        protected override double CalculateSpeed()
        {
            return _speed;
        }

        protected override double CalculatePace()
        {
            return 60 / _speed;
        }
}