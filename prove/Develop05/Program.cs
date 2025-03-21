using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Enter your player name: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);
        GoalManager goalManager = new GoalManager();
        Menu menu = new Menu(goalManager, player);

        Console.Clear();
        menu.Start();
    }
   // Added a whole player class and implementation to track your player's score, level, etc. 
    // Can also save/load the player data as well. Be sure to make your terminal a bit bigger
    // to see everything. 
} 