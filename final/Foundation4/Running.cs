public class Running:Activity
{
    private double _distance;

    public Running(string date, double length, double distance, float minutes) : base(date, length,minutes)
    {
        _distance = distance;
    }

    protected override double CalculateDistance()
    {
        return _distance;
    }

    protected override double CalculateSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    protected override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}