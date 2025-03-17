using System;
using System.Reflection;

public class SimpleGoal : Goal
{
  private bool _completed;

  public SimpleGoal(string name, string description, int points)
  : base(name, description, points)
    {
        _completed = false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}";
    }

    public override int RecordEvent()
    {
        if (!_completed)  
        {
            _completed = true;  
            return _points;  
        }

        return 0;  
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GoalStatus()
    {
        return _completed ? "[X] " + _name : "[ ] " + _name;
    }
}