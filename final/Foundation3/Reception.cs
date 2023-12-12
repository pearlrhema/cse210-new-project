public class Reception:Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _email = email;
    }
    public string FullDetails()
    {
        return $"{StandardDetails()}\nEmail: {_email}";
    }
}