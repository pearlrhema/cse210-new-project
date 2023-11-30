
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _goalname = name;
        _goalDescription = description;
        _goalPoints = points;
        _isComplete = isComplete;
    }

    public override string GetType(string type)
    {
        type = "SimpleGoal";
        return base.GetType(type);
    }
    public override string GetSaveString()
    {
        return $"{GetType()}|{_goalname}|{_goalDescription}|{_goalPoints}|{_isComplete}";
    }
   
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congrats you have completed {_goalname} and have earned {_goalPoints} points");
        return _goalPoints;
    }
}
