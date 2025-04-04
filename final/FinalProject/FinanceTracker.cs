using System;

public class FinanceTracker
{
    private List<Transaction> _transactions;
    private List<Budget> _budgets;
    private CategoryManager _categoryManager = new CategoryManager();

    public FinanceTracker()
    {
        _transactions = new List<Transaction>();
        _budgets = new List<Budget>();
    }

    public void AddTransaction(bool isIncome)
    {
        Console.WriteLine("Enter transaction amount: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter category: ");
        string rawCategory = Console.ReadLine();
        string category = _categoryManager.GetNormalizedNaming(rawCategory);

        DateTime date = DateTime.Now;

        Transaction transaction = isIncome ? new Income(amount, category, date) 
        : new Expense(amount, category, date);

        if (!_categoryManager.CategoryExists(category))  
        {
            _categoryManager.AddCategory(category);      
        }

        _transactions.Add(transaction);
        Console.WriteLine("\nTransaction added.");

        if (!isIncome)
        {
            foreach (Budget budget in _budgets)
            {
                if (budget.Category == category)
                {
                    budget.AddSpending(amount);
                    if (budget.IsOverBudget())
                    {
                        Console.WriteLine($"\nWarning: You have exceeded your budget in {category}.");
                    }
                    break;
                }
            }
        }
    }

    public void ViewTransactions()
    {
        Console.WriteLine("\nTransactions:");
        if (_transactions.Count == 0)
        {
            Console.WriteLine("No transactions recorded.");
        }

        else

        {

            foreach (Transaction transaction in _transactions)
            {
                transaction.Display();
            }
        }
    }

    public List<Transaction> GetTransactions()
    {
        return _transactions;
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter filename: ");
        string fileName = Console.ReadLine();

        FileStorage.SaveTransactions(_transactions, fileName + "_transactions.txt");
        FileStorage.SaveBudgets(_budgets, fileName + "_budgets.txt");

        Console.WriteLine("\nData saved.");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter filename: ");
        string fileName = Console.ReadLine();

        _transactions = FileStorage.LoadTransactions(fileName + "_transactions.txt");
        _budgets = FileStorage.LoadBudgets(fileName + "_budgets.txt");

        Console.WriteLine("\nData loaded.");
    }

    public void SetBudget()
    {
        Console.Write("Enter category for budget: ");
        string rawCategory = Console.ReadLine();
        string category = _categoryManager.GetNormalizedNaming(rawCategory);

        Console.Write("Enter the budget limit: ");
        decimal limit = Convert.ToDecimal(Console.ReadLine());

        Budget budget = new Budget(category, limit);
        _budgets.Add(budget);
        Console.WriteLine("Budget has been set.");
    }

    public void ViewBudgets()
    {
        if (_budgets.Count == 0)
        {
            Console.WriteLine("No budgets set.");
        }

        else
        {
            foreach (Budget budget in _budgets)
            {
                Console.WriteLine($"{budget.Category}: Limit = {budget.Limit:C}, Spent = {budget.Spent:C}, Over Budget: {budget.IsOverBudget()}, Created On: {budget.Created}");
            }
        }
    }
}