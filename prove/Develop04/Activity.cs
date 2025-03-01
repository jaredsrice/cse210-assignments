using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

public class Activity
{
   protected string _name;
   protected string _description;
   protected int _duration;

   public Activity(string name, string description)
   {
        _name = name;
        _description = description;
   } 

   public void StartActivity()
   {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        SetDuration();
   }

   public void EndActivity()
   {
        Console.WriteLine($"You've completed the {_name} for {_duration} seconds.");
        Console.WriteLine("Press enter to return to menu.");
        Console.ReadLine();
        Countdowns.SpinnerPause(3);    
        Console.Clear();
   }

   private void SetDuration()
   {
        while (true)
        {
            Console.WriteLine("How long would you like to do the " + _name + "? (in seconds)");
            string durationInput = Console.ReadLine();

            if (int.TryParse(durationInput, out int duration) && duration > 0)
            {                    
                _duration = duration;
                break;
            }

            else
            {
                Console.WriteLine("Womp womp, enter a valid input.");
            }
        }
   }
}