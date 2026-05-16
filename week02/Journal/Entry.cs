using System;

public class Entry
{
    public string Date { get; private set; }
    public string Time { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }

    public Entry(string date, string time, string promptText, string entryText)
    {
        Date = date;
        Time = time;
        PromptText = promptText;
        EntryText = entryText;
    }

    public string GetDisplayString()
    {
        return $"Date: {Date} {Time}\nPrompt: {PromptText}\nEntry: {EntryText}\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Time}|{PromptText}|{EntryText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}