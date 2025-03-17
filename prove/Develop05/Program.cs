using System;
using System.ComponentModel.Design;

public class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        Menu menu = new Menu(goalManager);
        menu.Start();
    }
}