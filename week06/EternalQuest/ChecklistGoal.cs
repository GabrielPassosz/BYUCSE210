using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _timesCompleted;
    private int _targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int timesCompleted)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This checklist goal is already complete.");
            return 0;
        }

        _timesCompleted++;

        if (_timesCompleted == _targetCount)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_targetCount}|{_timesCompleted}";
    }
}