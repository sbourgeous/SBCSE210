using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Dataflow;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // Adds the newest entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        // Checks if there is currently journal entries
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            Console.WriteLine();
            return;
        }
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void Save(string file)
    {
        // Saves the users journal entry
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.GetCsvVersion());
            }
        }
        Console.WriteLine("Journal saved successfully!");
        Console.WriteLine();
    }

    public void LoadFromFile(string file)
    {
        // Loads a users journal entry
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            Console.WriteLine();
            return;
        }
        // Clears an exsiting journal entry before loading a new one
        _entries.Clear();
        foreach (var line in File.ReadAllLines(file))
        {
            string[] parts = line.Split(',');
            if (parts.Length == 4)
            {
                _entries.Add(new Entry { Author = parts[0], Date = parts[1], PromptQuestion = parts[2], Response = parts[3] });
            }
        }
        Console.WriteLine("Journal loaded successfully!");
        Console.WriteLine();
    }
}