using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new()
        {
            new Running("14-Dec-2023", 60, 1,25),
            new Cycling("14-Dec-2023", 60, 60,45),
            new Swimming("14-Dec-2023", 60, 20,25)
        };

        foreach (Activity activity in list)
        {
            activity.DisplaySummary();
        }
    }
}