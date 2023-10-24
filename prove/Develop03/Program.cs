using System;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string text = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        string book = "Moroni";
        string chapter = "10";
        string verse = "4";
        string endVerse = "5";
        Reference reference;
        Scripture scripture;

        // this program exceeds the core requirement as the program will always ask the user for new scriptural text and
        //reference to be used for the memorization.

        Console.Write("If you would like to add another Scriptural text, enter yes else enter no\n> ");
        while (choice.ToLower() != "no" && choice.ToLower() != "yes")
        {
            choice = Console.ReadLine();
            if (choice.ToLower() != "no" && choice.ToLower() != "yes")
            {
                Console.Write("please enter either yes or no\n> ");
            }
        }
        if (choice == "no")
        {
            Console.WriteLine("Thank you for your input. press enter to continue");
            Console.ReadLine();
            reference = new Reference(book, chapter, verse, endVerse);
            scripture = new Scripture(reference, text);
        }
        else
        {
            Console.Write("Please enter the text\n> ");
            text = Console.ReadLine();
            Console.Write("Does the reference have one or mutiple verses\n> ");
            while (choice.ToLower() != "one" && choice.ToLower() != "multiple")
            {
                choice = Console.ReadLine();
                if (choice.ToLower() != "one" && choice.ToLower() != "multiple")
                {
                    Console.Write("Please enter either 'one' or 'multiple'\n> ");
                }
            }
            Console.Write("Enter the book\n> ");
            book = Console.ReadLine();
            Console.Write("Enter the chapter\n> ");
            chapter = Console.ReadLine();
            if(choice.ToLower() == "one")
            {
                Console.Write("Enter the verse\n> ");
                verse = Console.ReadLine();
                reference = new Reference(book, chapter, verse);
                scripture = new Scripture(reference, text);
            }
            else
            {
                Console.Write("Enter the start verse\n> ");
                verse = Console.ReadLine();
                Console.Write("Enter the end verse\n> ");
                endVerse = Console.ReadLine();
                reference = new Reference(book, chapter, verse, endVerse);
                scripture = new Scripture(reference, text);
            }
        }

        while (true)
        {
            scripture.GetRenderedText();
            Console.Write("\n\nPress enter if you wish to continue, else type quit: ");
            if (scripture.WordsHidden())
                break;

            string userChoice = Console.ReadLine();
            if (userChoice == "quit")
                break;

            int counter = 0;
            while (counter < 3 && !scripture.WordsHidden())
            {
                scripture.HideWord();
                counter++;
            }
        }

    }
}