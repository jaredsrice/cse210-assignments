using System;
using System.ComponentModel;

public class Activity
{
   protected string _name;
   protected string _description;
   protected int _duration;

   public Activity(string name, string description, int duration)
   {
    _name = name;
    _description = description;
    _duration = duration;
   } 

   public void StartActivity()
   {
    Console.WriteLine($"Starting {_name}");
    Console.WriteLine(_description);
    Console.WriteLine($"Duration: {_duration} seconds.");
    PauseWithCountdown();
   }

   public void EndActivity()
   {
    Console.WriteLine($"You've completed the {_name} for {_duration} seconds.");
    Console.WriteLine("Press enter to return to menu.");
    Console.ReadLine();
    PauseWithCountdown();
    Console.Clear();
   }

   public void PauseWithCountdown()
   {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(9);

    List<string> animation = new List<string>{"|", "/", "_", "\\", "|", "/", "‾", "\\"};

    int i = 0;

    while (DateTime.Now < endTime)
    {
        string decals = animation[i];
        Console.Write(decals);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;

        if (i >= animation.Count)
        {
            i = 0;
        }
    }
   }

   public void RunActivity()
   {
    StartActivity();
    EndActivity();
   }
}