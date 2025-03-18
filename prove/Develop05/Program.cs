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
}
