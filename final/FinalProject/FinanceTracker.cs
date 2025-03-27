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
        foreach (Transaction transaction in _transactions)
        {
            Console.WriteLine(transaction.GetTransactionType() + "-" + transaction._amount + "-" + transaction._category + "-" + transaction._date);
        }
    }
// public void SetBudget()
// public void SavetoFile()
// public void LoadFromFile()
}