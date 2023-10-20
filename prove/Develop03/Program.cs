using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string newText = "and it came to pass that the lord spake unto me saying";
        string book = "Moroni";
        string chapter = "10";
        string verse = "1";
        // PUT Do you want to enter an end verse?
        // answer = GET
        //  IF answer = "Y"
        //      string endVerse = GET
        //      Reference newReference = new Reference(book, chapter, verse, endVerse);
        //  ELSE
        //      reference = New(book, chapter, verse)
        string endVerse = "2";
        Reference newReference = new Reference(book, chapter, verse, endVerse);

        
        Scripture scripture = new Scripture(newReference, newText);
       
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