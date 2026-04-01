using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _unusedPrompts;
    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items!");

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