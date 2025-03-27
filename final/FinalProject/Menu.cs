using System;
using System.Runtime.InteropServices;

public class Menu
{
    private FinanceTracker _financeTracker = new FinanceTracker();

    public static void ShowMenu()
    {
        Console.WriteLine("\nFinance Tracker Menu:");
        Console.WriteLine("1. Add Income");
        Console.WriteLine("2. Add Expense");
        Console.WriteLine("3. View Transactions");
        Console.WriteLine("4. Set Budget");
        Console.WriteLine("5. Save to File");
        Console.WriteLine("6. Load from File");
        Console.WriteLine("7. Exit");
    } 

    public static int GetUserChoice()
    {
        Console.WriteLine("Please enter your choice: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 7))
            {
                return choice;
            }

            Console.WriteLine("\nThat's not a valid choice. Please choose again.\n");
    }

    public void RunMenu(int choice)
    {
        while (choice != 7)
        {
            ShowMenu();
            choice = GetUserChoice();
                
            if (choice == 1)
            {
                _financeTracker.AddTransaction();
            }
            else if (choice == 2)
            {
                _financeTracker.AddTransaction();
            }
            else if (choice == 3)
            {
                _financeTracker.ViewTransactions();
            }
            else if (choice == 4)
            {
                _financeTracker.SetBudget();
            }
            else if (choice == 5)
            {
                _financeTracker.SaveToFile();
            }
            else if (choice == 6)
            {
                _financeTracker.LoadFromFile();
            }
            else if (choice == 7)
            {
                Console.WriteLine("Bye Bye.");
                break;
            }
        }
    }
}

