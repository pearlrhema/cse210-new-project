using System.Collections.Concurrent;

public class Reference
{
    // private string _reference;
    private string _book;
    private string _chapter;
    private string _verse;
    private string _lastVerse;

    public Reference(string book, string chapter, string verse)
    {
        // BUild the reference string
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {

        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = endVerse;
    }

    // Getter method for the reference string
    public string GetReference() {
        if(_lastVerse == null)
            return _book + " " +  _chapter + ":" + _verse + " ";
        else
            return _book + " " +  _chapter + ":" + _verse + "-" + _lastVerse + " ";
    }/*i want to be able to return the variables that i have set to the Reference attributes*/
}