using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    List<Entry> entries = new List<Entry>();
    public void AddEntries(Entry entry)
    {
        entries.Add(entry);
    }    

    public void DisplayEntry()
    {
        foreach (Entry item in entries)
        {
            Console.WriteLine($"{item._date} {item._prompt}");
            Console.WriteLine($"{item._userRespond}");
        }
    }

    public void  SaveToFile(string userFile)
    {
        string filename = userFile;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry item in entries)
            {
                outputFile.WriteLine($"{item._date} {item._prompt}");
                outputFile.WriteLine($"{item._userRespond}");
            }
        }
    }

    public void ReadFromFile(string userFile)
    {
        String filename = userFile;
        //using (StreamReader outputFile = new StreamReader(filename))
        string[] Lines = System.IO.File.ReadAllLines(userFile);
        foreach (Entry item in entries)
        {
            Console.WriteLine($"{item._date} {item._prompt}");
            Console.WriteLine($"{item._userRespond}");
        }

    }
}