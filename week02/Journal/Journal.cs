using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    private List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
       _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in this journal.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, append: false))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e._date);
                outputFile.WriteLine(e._promptText);
                outputFile.WriteLine(e._entryText);
                outputFile.WriteLine();
            }
        }
        Console.WriteLine($"Journal save to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File not found: {filename}");
            return;
        }

        _entries.Clear();
        
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4)
        {
            if (i + 2 >= lines.Length)
            {
                break;
            }

            Entry entry = new Entry();

            entry._date = lines[i];
            entry._promptText = lines[i + 1];
            entry._entryText = lines [i + 2];

            AddEntry(entry);
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}