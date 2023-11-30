public class GoalsOverview
{
    // ATTRIBUTES
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public int Score {get{return _score;}}

    public void CreateNewGoal()
    {

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goals");
        Console.WriteLine(" 2. Eternal Goals");
        Console.WriteLine(" 3. checklist Goals");
        Console.Write("what type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        do
        {
            if (choice == 1)
            {
                Console.Write("what is the name of the Goal? ");
                string name = Console.ReadLine();
                Console.Write("what is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simple = new(name, description, points);
                _goals.Add(simple);
            }
            else if (choice == 2)
            {
                Console.Write("what is the name of the Goal? ");
                string name = Console.ReadLine();
                Console.Write("what is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                EternalGoal eternal = new(name, description, points);
                _goals.Add(eternal);
            }
            else if (choice < 1 || choice > 3 )
            {
                Console.WriteLine("invalid input");
                return;
            }
            else
            {
                Console.Write("what is the name of the Goal? ");
                string name = Console.ReadLine();
                Console.Write("what is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                
                Console.Write("how many times would you like to perform this goal? ");
                int target = int.Parse(Console.ReadLine());
                
                Console.Write("How many bonus points would you like to get for completing this task ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklist = new(name, description, points, target, bonus);
                _goals.Add(checklist);
            }
        }while (choice !< 1 || choice !> 3);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{++counter}) {goal.DisplayGoal()}");
        }
        Console.WriteLine();
    }

    public void RecordGoalEvent()
    {
        DisplayGoals();
        Console.WriteLine("Please select a goal >");
        int index = int.Parse(Console.ReadLine()) - 1;
        while (index !< 1 || index !> _goals.Count)
        {
            if (_goals[index].IsComplete)
            {
                Console.WriteLine("Goal is already completed");
                return;
            }
            else if (index >= 1 || index <= _goals.Count)
            {
                _score += _goals[index].RecordEvent();
                return;
            }
            else
            {
                Console.WriteLine("Invalid Goal");
            }
        }
    }

    public void SaveToFile(string userFile)
    {
        string filename = (userFile);

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(Score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
       
    }
    public void ReadFromFile(string userFile)
    {
        try
        {
            string[] Lines = System.IO.File.ReadAllLines(userFile);
            _goals.Clear();
            foreach (string Line in Lines)
            {
                string[] parts = Line.Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simple = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(simple);
                }

                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternal = new(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eternal);
                }

                else if(parts[0] == "checklist")
                {
                    ChecklistGoal checklist = new(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    _goals.Add(checklist);
                }
                else
                {
                    _score = int.Parse(parts[0]);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No Save file generated");
            return;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Acces to file is prohibited");
            return;
        }

    }
}