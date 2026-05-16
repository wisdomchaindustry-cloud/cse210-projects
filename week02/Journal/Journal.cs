using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayString());
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToFileFormat());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _entries.Add(Entry.FromFileFormat(line));
        }

        Console.WriteLine("Journal loaded successfully.");
    }

    public void SearchEntries(string keyword)
    {
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry.EntryText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(entry.GetDisplayString());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching entries found.");
        }
    }
}