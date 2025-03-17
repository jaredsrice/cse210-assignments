using System;
using System.Reflection;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCompletions;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int targetCompletions, int bonusPoints)
    : base (name, description, points)
    {
        _timesCompleted = 0;
        _targetCompletions = targetCompletions;
        _bonusPoints = bonusPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCompletions}|{_bonusPoints}";
    }

    public override int RecordEvent()
    {
       if (_timesCompleted >= _targetCompletions)
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
        
        _timesCompleted++;
        return _timesCompleted == _targetCompletions ? _points + _bonusPoints : _points;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCompletions;
    }

    public override string GoalStatus()
    {
        return $"[{_timesCompleted}/{_targetCompletions}] " + _name;
    }
}