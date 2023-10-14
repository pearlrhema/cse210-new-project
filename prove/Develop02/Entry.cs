public class Entry
{
    public string _date;
    public string _userRespond;
    public string _prompt;

    public void UserResponds(string date, string prompt, string userRespond)
    {
        _date = date;
        _prompt = prompt;
        _userRespond = userRespond;

        /*Console.WriteLine(_prompt);
        Console.WriteLine(_userRespond);
        Console.WriteLine(_date);*/
    }
}