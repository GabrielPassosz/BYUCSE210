using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a person who has positively influenced your life.",
        "Think of something simple that brought you joy recently.",
        "Think of a challenge that helped you grow.",
        "Think of something you often take for granted."
    };

    private List<string> _unusedPrompts;
    private Random _random = new Random();

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you focus on gratitude by inviting you to think deeply about people, experiences, and blessings in your life.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Reflect on the following gratitude prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("Spend this time thinking quietly about it...");
        Console.WriteLine();

        ShowSpinner(GetDuration());

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);
        string selected = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return selected;
    }
}