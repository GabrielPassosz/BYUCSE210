using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            string json = JsonSerializer.Serialize(
                _entries,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                }
            );

            File.WriteAllText(filename, json);
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error saving file: {exception.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string json = File.ReadAllText(filename);

            List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(
                json,
                new JsonSerializerOptions
                {
                    IncludeFields = true
                }
            );

            if (loadedEntries != null)
            {
                _entries = loadedEntries;
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File was empty or invalid.");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error loading file: {exception.Message}");
        }
    }
}