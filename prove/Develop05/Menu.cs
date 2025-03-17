using System;

public class Menu
{
    private GoalManager _goalManager;

    public Menu(GoalManager goalManager)
    {
        _goalManager = goalManager ?? throw new ArgumentNullException(nameof(goalManager));
    }

    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            Console.Clear();

            if (choice == 6)
            {
                Console.WriteLine("Goodbye! Exiting the program...\n");
                return;
            }

            RunMenu(choice);
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\nTotal Points: " + _goalManager.GetTotalPoints());
        Console.WriteLine("\nPlease choose an option:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit\n");
    }

    public int GetUserChoice()
    {
        while (true)
        {
            Console.Write("Please enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 6))
            {
                return choice;
            }

            Console.WriteLine("\nThat's not a valid choice. Please choose again.\n");
            DisplayMenu();
        }
    }

    public void RunMenu(int choice)
    {
        if (choice == 1)
        {
            _goalManager.CreateNewGoal();
        }
        else if (choice == 2)
        {
            _goalManager.ListGoals();
        }
        else if (choice == 3)
        {
            Console.Write("Enter filename to save goals: ");
            string filename = Console.ReadLine();
            _goalManager.SaveGoals(filename);
        }
        else if (choice == 4)
        {
            Console.Write("Enter filename to load goals: ");
            string filename = Console.ReadLine();
            _goalManager.LoadGoals(filename);
        }
        else if (choice == 5)
        {
            int goalNumber;
            Console.Write("Enter the goal number to record an event: ");
            while (!int.TryParse(Console.ReadLine(), out goalNumber) || goalNumber <= 0 || goalNumber > _goalManager.GetGoals().Count)
            {
                Console.Write("Invalid input. Enter a valid goal number: ");
            }

            Goal selectedGoal = _goalManager.GetGoals()[goalNumber - 1];
            int pointsAwarded = selectedGoal.RecordEvent();
            _goalManager.UpdateTotalPoints(pointsAwarded); 
            Console.WriteLine($"Event recorded. Points awarded: {pointsAwarded}");
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}