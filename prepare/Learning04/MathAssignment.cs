using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";
    public MathAssignment(string name, string topic, string text, string problem) : base(name,topic)
    {
        _textbookSection = text;
        _problem = problem;
    }
    public string GetSection(string section)
    {
        _textbookSection = section;
        return section;
    }
    public void SetSection(string section)
    {
        _textbookSection = section;
    }
    public string GetProblem(string problem)
    {
        _problem = problem;
        return problem;
    }
    public void SetProblem(string problem)
    {
        _problem = problem;
    }
    
    
    // public string TextbookSection
    // {
    //     get{return _textbookSection;}
    //     set{_textbookSection = value;}
    // }
    // public string Problem
    // {
    //     get{return _problem;}
    //     set{_problem = value;}
    // }

    public string GetHomeWorkList()
    {
        // _textbookSection = section;
        // _problem = problem;
        return $"Student Name: {_studentName} Topic: {_topic} Section: {_textbookSection} Problem {_problem}";    // }
    }
}