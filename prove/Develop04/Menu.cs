using System;

public class Menu
{
    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();
            if (choice == 4)
            {
                Activity activity = new Activity("Quit", "End the program", 0);
                activity.PauseWithCountdown();
                Console.WriteLine("\nProgram go bye bye.\n");
                return;
            }

            RunActivity(choice);
            Console.WriteLine();
        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("\nPlease choose an activity:");
        Console.WriteLine("   1. Breathing Activity");
        Console.WriteLine("   2. Reflecting Activity");
        Console.WriteLine("   3. Listing Activity");
        Console.WriteLine("   4. Quit\n");
    }
    
    public int GetUserChoice()
    {
        Console.Write("Please enter your choice: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice))
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return -1;
        }
    }

    public void RunActivity(int choice)
    {
        if (choice == -1)
        {
            Console.WriteLine("Wrong choice, womp womp. Try again.");
        }

        Console.Clear();

        if (choice == 1)
        {
            Console.WriteLine("\nStarting Breathing Activity.");
            BreathingActivity activityOne = new BreathingActivity();
            // activityOne.RunActivity();
        }

        else if (choice == 2)
        {
            Console.WriteLine("\nStarting Reflecting Activity.");
            ReflectingActivity activityTwo = new ReflectingActivity();
            // activityTwo.RunActivity();
        }

        else if (choice == 3)
        {
            Console.WriteLine("\nStarting Listing Activity.");
            ListingActivity activityThree = new ListingActivity();
            // activityThree.RunActivity();
        }

    }
}
