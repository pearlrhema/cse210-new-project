using System.Reflection.Metadata;

public class Word
{
    private string _word;
    private string _underscoreWord = "";
    private bool _hiddenStatus;
    //PROPERTY
    //(ACCESS TYPE) (RETURN TYPE) (NAME) {}
    public bool HiddenStatus
    {   
        get{return _hiddenStatus;}
        //word.HiddenStatus
        set{_hiddenStatus = value;}
        //word.HiddenStatus = true
    }

    //CONSTRUCTOR
    public Word(string word)
    {
        _word = word;
        foreach (char letter in word)
        {
            _underscoreWord += "_";
        }
    }

    //GETTERS
    // public bool GetHiddenStatus()   {return _hiddenStatus; }
    public string GetWord()
    {
        if(_hiddenStatus)
        {
            return _underscoreWord;
        }
        else
        {
            return _word;
        }
    }

    //SETTER
    // public void SetHiddenStatus(bool status)
    // {
    //     //Additional logic...
    //     _hiddenStatus = status;
    //     //Additional logic...
    // }
}