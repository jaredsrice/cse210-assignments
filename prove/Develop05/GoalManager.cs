using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Transactions;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

public void CreateNewGoal()
{
    Console.WriteLine("Choose goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Enter Choice: ");
    string choice = Console.ReadLine();

    Console.Write("Enter Goal Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Goal Description: ");
    string description = Console.ReadLine();

    int points;
    Console.Write("Enter Goal Points: ");
    if (!int.TryParse(Console.ReadLine(), out points) || points < 0) 
    {
        Console.WriteLine("Invalid points value. Defaulting to 0.");
        points = 0;
    }

    Goal newGoal = null;

    if (choice == "1")  
    {
        newGoal = new SimpleGoal(name, description, points);
    }
    else if (choice == "2")
    {
        newGoal = new EternalGoal(name, description, points);
    }
    else if (choice == "3")
    {
        Console.Write("Enter target completions: ");
        if (!int.TryParse(Console.ReadLine(), out int targetCompletions) || targetCompletions <= 0)
        {
            Console.WriteLine("Invalid value. Defaulting to 1.");
            targetCompletions = 1;
        }

        Console.Write("Enter bonus points: ");
        if (!int.TryParse(Console.ReadLine(), out int bonusPoints) || bonusPoints < 0)
        {
            Console.WriteLine("Invalid value. Defaulting to 0.");
            bonusPoints = 0;
        }

        newGoal = new ChecklistGoal(name, description, points, targetCompletions, bonusPoints);
    }
    else
    {
        Console.WriteLine("Invalid goal type. Goal not created.");
        return;
    }

    if (newGoal != null)
    {
        _goals.Add(newGoal);  
        Console.WriteLine("Goal successfully created!");
    }
}

    public void ListGoals()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals available.");
        return;
    }

    Console.WriteLine("\nYour Goals:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GoalStatus()}");
    }
}

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                if (!int.TryParse(parts[3], out int points) || points < 0)
                {
                    Console.WriteLine($"Invalid points value in file: {parts[3]}. Skipping goal.");
                    continue;
                }

                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(name, description, points));
                }

                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }

                else if (type == "ChecklistGoal")
                {
                   if (!int.TryParse(parts[4], out int targetCompletions) || targetCompletions <= 0)
                    {
                        Console.WriteLine($"Invalid target completions in file: {parts[4]}. Skipping goal.");
                        continue;
                    }

                    if (!int.TryParse(parts[5], out int bonusPoints) || bonusPoints < 0)
                    {
                        Console.WriteLine($"Invalid bonus points in file: {parts[5]}. Skipping goal.");
                        continue;
                    }
                    _goals.Add(new ChecklistGoal(name, description, points, targetCompletions, bonusPoints));
                }
            }
            Console.WriteLine("Goals loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void UpdateTotalPoints(int points)
    {
        _totalPoints += points; 
    }
}