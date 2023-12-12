public class Comment
{
    public string _commentor;
    public string _comment;
    
    public void DisplayComment()
    {
        Console.WriteLine($"\tCommentor: {_commentor}");
        Console.WriteLine($"\tComment: {_comment}");
    }
    public Comment(string commentor, string comment)
    {
        _commentor = commentor;
        _comment = comment;
    }
}