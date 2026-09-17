using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach(Entry _entry in _entries)
            {
                writer.WriteLine($"""
                Date : {_entry._date} - Prompt : {_entry._promptText}
                {_entry._entryText}
                
                """);
            }
        }
}

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string fileContents = File.ReadAllText(file);
            Console.WriteLine(fileContents);
        }
        else
        {
            Console.WriteLine("This file is not available");
        }
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry _entry in _entries)
        {
            _entry.DisplayEntry();
            Console.WriteLine();
        }

        
    }

}