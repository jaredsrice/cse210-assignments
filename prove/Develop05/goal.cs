using System;
using System.Reflection;

public abstract class Goal
{
   protected string _name;
   protected string _description;
   protected int _points;

   public Goal(string name, string description, int points)
   {

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || points < 0)
    {
        throw new ArgumentException("Invalid Input: Name and Description must have a value, and points must be greater than 0.");
    }

    _name = name;
    _description = description;
    _points = points;
   }  

   public string GetName()
   {
    return  string.IsNullOrEmpty(_name) ? "No name given": _name;
   }

   public string GetDescription()
   {
    return string.IsNullOrEmpty(_description) ? "No description given." : _description;
   }

   public int GetPoints()
   {
    return _points < 0 ? 0 : _points;
   }

   public abstract int RecordEvent();
   public abstract bool IsComplete();
   public abstract string GoalStatus();
   public abstract string GetStringRepresentation();
}