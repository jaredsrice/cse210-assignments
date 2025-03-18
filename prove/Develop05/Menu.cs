using System;

public class Menu
{
    private GoalManager _goalManager;
    private Player _player;

    public Menu(GoalManager goalManager, Player player)
    {
        _goalManager = goalManager ?? throw new ArgumentNullException(nameof(goalManager));
        _player = player ?? throw new ArgumentNullException(nameof(player));
    }

    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            Console.Clear();

            if (choice == 8)
            {
                Console.WriteLine("Goodbye! Exiting the program...\n");
                return;
            }

            RunMenu(choice);
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine(_player.GetStatus());  
        Console.WriteLine("\nTotal Points: " + _goalManager.GetTotalPoints());
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Save Player");
        Console.WriteLine("   7. Load Player");
        Console.WriteLine("   8. Quit\n");
    }

    public int GetUserChoice()
    {
        while (true)
        {
            Console.Write("Please enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 8))
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

            _player.AddScore(pointsAwarded);  
            _goalManager.UpdateTotalPoints(pointsAwarded);

            Console.WriteLine($"Event recorded. Points awarded: {pointsAwarded}");
        }
        else if (choice == 6)
        {
            Console.Write("Enter filename to save player data: ");
            string filename = Console.ReadLine();
            _player.SavePlayer(filename);
        }
        else if (choice == 7)
        {
            Console.Write("Enter filename to load player data: ");
            string filename = Console.ReadLine();
            _player.LoadPlayer(filename);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}