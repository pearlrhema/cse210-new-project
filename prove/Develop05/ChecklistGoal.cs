public class ChecklistGoal : Goal
{
    // ATTRIBUTES
    private int _target;
    private int _current;
    private int _bonus;

    // CONSTRUCTORS
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int current, int target, int bonus) : base(name, description, points, isComplete)
    {
        _target = target;
        _current = current;
        _bonus = bonus;
        _goalname = name;
        _goalDescription = description;
        _goalPoints = points;
        _isComplete = isComplete;
    }

    public override string GetSaveString()
    {
        return $"{GetType()}|{_goalname}|{_goalDescription}|{_goalPoints}|{_isComplete}|{_current}|{_target}|{_bonus}";
    }
    
    public override int RecordEvent()
    {
        _current ++;
        if (_current == _target)
        {
            _isComplete = true;
            int totalPoints = _goalPoints + _bonus;
            Console.WriteLine($"Congrats you completed the goal and earned {totalPoints} points");
            return totalPoints;
        }
        else
        {
            Console.WriteLine($"Congrats you completed the goal and earned {_goalPoints} points");
            return _goalPoints;
        }
    }

    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()} [{_current} / {_target}]";
    }
}