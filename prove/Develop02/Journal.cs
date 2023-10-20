using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    List<Entry> entries = new List<Entry>();
    public void AddEntries()
    {
        Entry entry = new();
        entry.Write();
        entries.Add(entry);
    }    

    public void DisplayEntry()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void  SaveToFile(string userFile)
    {
        string filename = userFile;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry item in entries)
            {
                outputFile.WriteLine($"{item._date}|{item._prompt}|{item._userRespond}");
            }
        }
    }

    public void ReadFromFile(string userFile)
    {
        //using (StreamReader outputFile = new StreamReader(filename))
        string[] Lines = System.IO.File.ReadAllLines(userFile);
        foreach (string Line in Lines)
        {
            string[] parts = Line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._userRespond = parts[2];

            entries.Add(newEntry);
            
        }

    }
}