public class Scripture
{
    private Reference _reference;
    private Random rnd = new();
    private List<Word> _words = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[]words = text.Split(" ");
        foreach (string singleWord in words)
        {
            Word word = new Word(singleWord);
             
            _words.Add(word);

        }
    }
    public void GetRenderedText()
    {
        Console.Clear();
        Console.WriteLine("Welcome to our Scipture Memorizer");
        Console.WriteLine("");
        Console.Write($"Our Scripture for today is {_reference.GetReference()}");
        foreach (Word item in _words)
        {
            Console.Write($"{item.GetWord()} ");
        }

    }

    public void HideWord()
    {
        int index;
        do
        {
            index = rnd.Next(_words.Count);
        } while( _words[index].HiddenStatus );

        _words[index].HiddenStatus = true;
    }

    public bool WordsHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.HiddenStatus)
            {
                return false;
            }
        }
        return true;
    }
    public void NewScriptureText()
    {
        Console.Write("Would you like to create a new scripture? ");
    }
}