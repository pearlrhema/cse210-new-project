public class Listing : Activity
{
    protected string[] _prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    Random rnd = new();

    public Listing() : base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }

    public void GenerateRandomPrompt()
    {
        int index = rnd.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
    }
    public void GetRandomPrompt()
    {
        int listLenght = _prompts.Length;
        int randomNumber = rnd.Next(0, listLenght);
        string prompt = _prompts[randomNumber];
        Console.WriteLine(prompt);
        
    }

    public void RunListingActivity()
    {
        Console.Clear();
        DisplayIntro(_activityName, _description);
        int counter = 0;
        Console.WriteLine("Consider the following prompts");
        GenerateRandomPrompt();
        DisplayTimer(5);
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"you have entered {counter} items");
        DisplayClosing(_activityName,_duration);
    }
}