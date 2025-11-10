using System;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    // Parameterless constructor needed for JSON deserialization
    public Entry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }
}