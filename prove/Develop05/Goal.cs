public abstract class Goal
{
    // ATTRIBUTES
    protected string _goalType;
    protected string _goalname;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isComplete;
    public bool IsComplete { get { return _isComplete; } }

    // CONSTRUCTORS
    // This constructor is used when the user first creates the goal
    public Goal(string name, string description, int points)
    {
        _goalname = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    //This constructor is used when reading in the data from a file
    public Goal(string name, string description, int points, bool isComplete)
    {
        _goalname = name;
        _goalDescription = description;
        _goalPoints = points;
        _isComplete = false;
    }

    // METHod
    private char GetIsCompleteChar()                        // char represent a single character
    {
        if (_isComplete)
            return 'X';                                     // char uses single quotes ' '
        else
            return ' ';
    }

    public virtual string DisplayGoal()
    {
        return $"[{GetIsCompleteChar()}] {_goalname} - {_goalDescription}";

    }

    public abstract string GetSaveString();
    public abstract int RecordEvent();
}