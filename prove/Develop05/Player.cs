using System;

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

    public void SavePlayer(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_name);
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_experience);
        }
        Console.WriteLine("Player data saved.");
    }

    public void LoadPlayer(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _name = reader.ReadLine();
                _score = int.Parse(reader.ReadLine());
                _level = int.Parse(reader.ReadLine());
                _experience = int.Parse(reader.ReadLine());
            }
            Console.WriteLine("Player data loaded.");
        }
        else
        {
            Console.WriteLine("Player file not found.");
        }
    }
}