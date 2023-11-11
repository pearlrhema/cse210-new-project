public class Reflection : Activity
{
    private string[] _reflectionPrompts = {
       "Think of a time when you stood up for someone else",
       "Think of a time when you did something really difficult",
       "Think of a time when you helped someone in need",
       "Think of a time when you did something truly selfless."
    };
    private string[] _reflectionPromptsQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    // Prompts ARRAY
    // Questions ARRAY

    // Constructor
    public Reflection():base()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    

    // GenerateRandomPrompt()
    Random rnd = new();
    public void ReflectionPrompts()
    {
        int index = rnd.Next(_reflectionPrompts.Length);
        Console.WriteLine($"    ---{_reflectionPrompts[index]}---");
    }
    // GenerateRandomQuestion()
    public void ReflectionPromptsQuestions()
    {
        int index = rnd.Next(_reflectionPromptsQuestions.Length);
        Console.WriteLine($"> {_reflectionPromptsQuestions[index]}");
    }
  
    public void RunReflectionActivity()
    {
        Console.Clear();
        DisplayIntro(_activityName, _description);
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine();
        ReflectionPrompts();
        Console.WriteLine();
        Console.WriteLine("when you have something in mind press enter ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to the experience");
        Console.Write("You may begin in ");
        DisplayTimer(5);
        Console.WriteLine();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            ReflectionPromptsQuestions();
            DisplaySpinner();
        }
        DisplayClosing( _activityName, _duration);
    } 
}