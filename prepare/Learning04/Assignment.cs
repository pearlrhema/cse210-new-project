public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetStudentName(string name)
    {
        _studentName = name;
        return name;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string Gettopic(string topic)
    {
        _topic = topic;
        return topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Student Name: {_studentName} Topic: {_topic}";
    }
}