using System;

public class FinanceTracker
{
    private List<Transaction> _transactions;
    private List<Budget> _budgets;
    private CategoryManager _categoryManager = new CategoryManager();

    public FinanceTracker()
    {
    }

    public void AddTransaction(bool isIncome)
    {
        Console.WriteLine("Enter transaction amount: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter category: ");
        string category = Console.ReadLine();
        DateTime date = DateTime.Now;

        Transaction transaction = isIncome ? new Income(amount, category, date) 
        : new Expense(amount, category, date);

        _transactions.Add(transaction);
        Console.WriteLine("Transaction added.");
    }

    public void ViewTransactions()
{
    Console.WriteLine("Transactions:");
    if (_transactions.Count == 0)
    {
        Console.WriteLine("No transactions recorded.");
    }
    else
    {
        foreach (Transaction transaction in _transactions)
        {
            // Console.WriteLine($"{transaction.GetTransactionType()} - {transaction.Amount} - {transaction.Category} - {transaction.Date}");
        }
    }
}

    public void SetBudget()
    {
        Console.WriteLine("SetBudget method called.");
    }

    public void SaveToFile()
    {
        Console.WriteLine("SaveToFile method called.");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("LoadFromFile method called.");
    }
}