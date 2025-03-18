using System;
using System.IO;

public class Player
{
    private string _name;
    private int _score;
    private int _level;
    private int _experience;

    public Player(string name)
    {
        _name = name;
        _score = 0;
        _level = 1;
        _experience = 0;
    }

    public void AddScore(int points)
    {
        _score += points;
        AddExperience(points); 
    }

    public void AddExperience(int xp)
    {
        _experience += xp;
        if (_experience >= _level * 100) 
        {
            _experience -= _level * 100;
            _level++;
            Console.WriteLine($"Congratulations, {_name}! You've leveled up to Level {_level}!");
        }
    }

    public string GetStatus()
    {
        return $"{_name} - Score: {_score}, Level: {_level}, XP: {_experience}/{_level * 100}";
    }

    public int GetScore()
    {
        return _score;
    }

    public string GetStringRepresentation()
    {
        return $"Player|{_name}|{_score}|{_level}|{_experience}";
    }

    public void SavePlayer(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(GetStringRepresentation());
        }
        Console.WriteLine("Player data saved.");
    }

    public void LoadPlayer(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');

                if (parts[0] == "Player" && parts.Length == 5)
                {
                    _name = parts[1];
                    _score = int.Parse(parts[2]);
                    _level = int.Parse(parts[3]);
                    _experience = int.Parse(parts[4]);

                    Console.WriteLine("Player data loaded.");
                }
                else
                {
                    Console.WriteLine("Invalid player data format. Failed to load player data.");
                }
            }
        }
        else
        {
            Console.WriteLine("Player file not found.");
        }
    }
}