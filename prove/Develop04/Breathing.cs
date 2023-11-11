public class Breathing : Activity
{
    public Breathing() : base() 
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayIntro(_activityName, _description);
        DisplaySpinner();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            DisplayTimer(5);
            Console.WriteLine("Now breathe out...");
            DisplayTimer(5);
        }
        DisplayClosing(_activityName,_duration);
        Console.Clear();
    }
}