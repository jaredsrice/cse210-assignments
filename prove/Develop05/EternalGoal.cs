using System;
using System.Reflection;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base (name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GoalStatus()
    {
       return "[∞] " + _name; 
    }
}