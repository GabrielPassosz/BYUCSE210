using System;
using System.Collections.Generic;

public class MindfulnessApp
{
    private bool _isRunning = true;
    private Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    public void Run()
    {
        while (_isRunning)
        {
            Console.Clear();
            ShowMenu();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunActivity(new BreathingActivity());
                    break;
                case "2":
                    RunActivity(new ReflectionActivity());
                    break;
                case "3":
                    RunActivity(new ListingActivity());
                    break;
                case "4":
                    RunActivity(new GratitudeActivity());
                    break;
                case "5":
                    ShowLog();
                    break;
                case "6":
                    _isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflection activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Start gratitude activity");
        Console.WriteLine("  5. View activity log");
        Console.WriteLine("  6. Quit");
        Console.WriteLine();
    }

    private void RunActivity(Activity activity)
    {
        activity.Run();
        string name = activity.GetName();

        if (_activityLog.ContainsKey(name))
        {
            _activityLog[name]++;
        }
        else
        {
            _activityLog[name] = 1;
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    private void ShowLog()
    {
        Console.Clear();
        Console.WriteLine("Session Activity Log");
        Console.WriteLine("--------------------");

        if (_activityLog.Count == 0)
        {
            Console.WriteLine("No activities completed yet.");
        }
        else
        {
            foreach (KeyValuePair<string, int> entry in _activityLog)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}