public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalname = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    //  PUBLIC GetSaveString()
    //      RETURN "{GetType()}|{goalName}|{GoalDescription}|{goalPoints}
 
    public override string GetSaveString()
    {
        return $"{GetType()}|{_goalname}|{_goalDescription}|{_goalPoints}";
    }

    //  PUBLIC RecordEvent()
    //      PUT "Congrats you completed the goal and earned {goalPoints} points"
    //      RETURN goalPoints  
    public override int RecordEvent()
    {
        Console.WriteLine($"Congrats you completed the goal and earned {_goalPoints} points");
        return _goalPoints;
    }
}