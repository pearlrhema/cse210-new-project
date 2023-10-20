public class Entry
{
    public string _date;
    public string _userRespond;
    public string _prompt;
    private PromptsGenerator pgen = new();

    public void Write()
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = pgen.GetRandomPrompt();
        Console.WriteLine(_prompt);
        _userRespond = Console.ReadLine();
    }

    public void Display()
    {
        Console.Write(_date + " ");
        Console.WriteLine(_prompt);
        Console.WriteLine(_userRespond);
    }
}