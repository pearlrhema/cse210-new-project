public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    private string[] spinner = {"|", "/", "-", "\\"};


    public void DisplayIntro(string name, string description)
    {
        Console.WriteLine($"welcome to the {name} activity");
        Console.WriteLine();
        Console.WriteLine($"{description}");
        Console.WriteLine();
        Console.WriteLine("how long in secs wuold you like for this session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Console.WriteLine();
        DisplaySpinner();
    }


    public void DisplayClosing(string activityName, int duration)
    {
        Console.WriteLine($"Congrats you have completed another {duration} seconds of the {activityName} Activity");
        DisplaySpinner();
        Console.Clear();
    }

    
    public void DisplaySpinner()
    {
        DateTime startime = DateTime.Now;
        DateTime end = startime.AddSeconds(10);

        while (DateTime.Now < end)
        {
            foreach (var item in spinner)
            {
                Console.Write(item);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
   

    public void DisplayTimer(int duration )
    {     
        for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
}