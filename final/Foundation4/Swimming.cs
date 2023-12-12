public class Swimming:Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps, float minutes) : base(date, length, minutes)
    {
        _laps = laps;
    }

    protected override double CalculateDistance()
    {
        double distance = ((_laps * 50) / 1000);
        return distance;
    }

    protected override double CalculateSpeed()
    {
        return (CalculateDistance() / _minutes) * 60;
    }

    protected override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}