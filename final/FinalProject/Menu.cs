using System;

public class Menu
{
    private FinanceTracker _financeTracker = new FinanceTracker();

    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to the Finance Tracker!");
        Console.WriteLine("================================");
        Console.WriteLine("Please choose an option from the menu below:");
        Console.WriteLine("================================");

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
        while (true)
        {
            Console.WriteLine("\nPlease enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 7))
            {
                return choice;
            }

            Console.WriteLine("\nThat's not a valid choice. Please choose again.\n");
        }
    }

    public void RunMenu(int choice)
    {
        {
            if (choice == 1)
            {
                _financeTracker.AddTransaction(true);  
            }
            else if (choice == 2)
            {
                _financeTracker.AddTransaction(false); 
            }
            else if (choice == 3)
            {
                _financeTracker.ViewTransactions();
            }
            else if (choice == 4)
            {
                Console.WriteLine("[DEBUG] Calling SetBudget()");
                _financeTracker.SetBudget();
            }
            else if (choice == 5)
            {
                Console.WriteLine("[DEBUG] Calling SaveToFile()");
                _financeTracker.SaveToFile();  
            }
            else if (choice == 6)
            {
                Console.WriteLine("[DEBUG] Calling LoadFromFile()");
                _financeTracker.LoadFromFile();
            }
            else if (choice == 7)
            {
                Console.WriteLine("Bye Bye.");
            }
        }
    }
}