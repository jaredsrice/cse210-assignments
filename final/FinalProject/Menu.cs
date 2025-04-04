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

        Console.WriteLine("1. Set Budget");
        Console.WriteLine("2. View Budgets");
        Console.WriteLine("3. Add Income");
        Console.WriteLine("4. Add Expense");
        Console.WriteLine("5. View Transactions");
        Console.WriteLine("6. Save to File");
        Console.WriteLine("7. Load from File");
        Console.WriteLine("8. View Financial Summary");
        Console.WriteLine("9. Exit");

    } 

    public static int GetUserChoice()
    {
        while (true)
        {
            Console.WriteLine("\nPlease enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && (choice >= 1 && choice <= 9))
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
                _financeTracker.SetBudget();
            }
            else if (choice == 2)
            {
                _financeTracker.ViewBudgets();
            }
            if (choice == 3)
            {
                _financeTracker.AddTransaction(true);  
            }
            else if (choice == 4)
            {
                _financeTracker.AddTransaction(false); 
            }
            else if (choice == 5)
            {
                _financeTracker.ViewTransactions();
            }
            else if (choice == 6)
            {
                _financeTracker.SaveToFile();  
            }
            else if (choice == 7)
            {
                _financeTracker.LoadFromFile();
            }
            else if (choice == 8)
            {
                ReportGenerator.ShowSummary(_financeTracker.GetTransactions());
            }
            else if (choice == 9)
            {
                Console.WriteLine("Bye Bye.");
            }
        }
    }
}