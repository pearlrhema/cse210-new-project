public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected float _minutes;

    public Activity(string date, double length, float minutes)
    {
        _date = date;
        _length = length;
        _minutes = minutes;
    }

    protected abstract double CalculateDistance();
    protected abstract double CalculateSpeed();
    protected abstract double CalculatePace();
    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} Swimming ({_minutes} min)\n\tDistance: {Math.Round(CalculateDistance(), 2)} km\n\tSpeed: {Math.Round(CalculateSpeed(), 2)} Kph\n\tPace: {Math.Round(CalculatePace(), 2)} min per km");
    }
}