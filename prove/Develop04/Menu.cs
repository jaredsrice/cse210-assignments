using System;

public class Menu
{
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu();
            int choice = GetUserChoice();

            if (choice == 4)
            {
                Activity activity = new Activity("Quit", "End the program");
                Countdowns.SymbolCountdown(5);
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
        while(true)
        {
            Console.Write("Please enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 4))
            {
                return choice;
            }

            Console.Clear();
            Console.WriteLine("\nWomp womp, that's not a valid choice. Do it again.\n");
            DisplayMenu();

        }
    }

    public void RunActivity(int choice)
    {
        Console.Clear();

        if (choice == 1)
        {
            BreathingActivity activityOne = new BreathingActivity();
            activityOne.StartBreathing();
        }

        else if (choice == 2)
        {
            ReflectingActivity activityTwo = new ReflectingActivity();
            activityTwo.StartReflecting();
        }

        else if (choice == 3)
        {
            ListingActivity activityThree = new ListingActivity();
            activityThree.StartListing();
        }

    }
}
