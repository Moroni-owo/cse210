using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetEntryAsString());
            }
        }
        Console.WriteLine($"Journal saved to {file}\n");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in lines)
            {
                Entry entry = Entry.FromString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {file}\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}
