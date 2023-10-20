using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string newText = "And when ye shall receive these things, I would exhort you that ye would aask God, the Eternal Father, in the name of Christ, if these things are not btrue; and if ye shall ask with a csincere heart, with dreal intent, having efaith in Christ, he will fmanifest the gtruth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may aknow the btruth of all things.";
        string book = "Moroni";
        string chapter = "10";
        string verse = "4";
        // PUT Do you want to enter an end verse?
        // answer = GET
        //  IF answer = "Y"
        //      string endVerse = GET
        //      Reference newReference = new Reference(book, chapter, verse, endVerse);
        //  ELSE
        //      reference = New(book, chapter, verse)
        string endVerse = "5";
        Reference newReference = new(book, chapter, verse, endVerse);

        
        Scripture scripture = new(newReference, newText);
       
        while( true )
        {
            scripture.GetRenderedText();
            Console.Write("\n\nPress enter if you wish to continue, else type quit: ");
            if(scripture.WordsHidden())
                break;

            string userChoice = Console.ReadLine();
            if(userChoice == "quit")
                break;

            int counter = 0;
            while(counter < 3 && !scripture.WordsHidden())
            {
                scripture.HideWord();
                counter++;
            }
        }
    }
}