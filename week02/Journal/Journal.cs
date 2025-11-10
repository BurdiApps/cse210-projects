using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// For JSON serialization, had to learn a lot on this one
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries;
    private List<string> _prompts;

    public Journal()
    {
        // initialize the _entries list
        _entries = new List<Entry>();
        _prompts = new List<string>();
        _prompts.Add("What was your high for the day? What was your low?");
        _prompts.Add("What are you most grateful for today?");
        _prompts.Add("Describe a challenge you faced today and how you overcame it.");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Who did you speak with that left an impact on you today?");
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
    }    // JSON save method - modern, clean format
    public void SaveToJson(string filename)
    {
        // Serialize the list to JSON with nice formatting
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions
        {
            WriteIndented = true  // Makes it readable with indentation
        });

        // Write to file
        File.WriteAllText(filename, jsonString);
        string fullPath = Path.GetFullPath(filename);
        Console.WriteLine($"Journal saved to: {fullPath}");
    }

    // JSON load method - reads JSON back into the list
    public void LoadFromJson(string filename)
    {
        // Read the JSON file
        string jsonString = File.ReadAllText(filename);

        // Deserialize JSON back into List<Entry>
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();

        string fullPath = Path.GetFullPath(filename);
        Console.WriteLine($"Journal loaded from: {fullPath}");
    }
}