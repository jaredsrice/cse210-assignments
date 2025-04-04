using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

    public class FileStorage
    {
        public static void SaveTransactions(List<Transaction> transactions, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Transaction transaction in transactions)
            {
                writer.WriteLine($"{transaction.GetTransactionType()},{transaction.Amount},{transaction.Category},{transaction.Date}");
            }
        }
    }

    public static List<Transaction> LoadTransactions(string filePath)
    {
        List<Transaction> transactions = new List<Transaction>();

        if (!File.Exists(filePath))
        {
            return transactions;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 4)
            {
                string type = parts[0];
                decimal amount = Convert.ToDecimal(parts[1]);
                string category = parts[2];
                DateTime date = DateTime.Parse(parts[3]);

                Transaction transaction;

                if (type == "Income")
                {
                    transaction = new Income(amount, category, date);
                }

                else if (type == "Expense")
                {
                    transaction = new Expense(amount, category, date);
                }

                else
                {
                    transaction = new Transaction(amount, category, date); // fallback
                }

                transactions.Add(transaction);
            }
        }
    return transactions;
    }

    public static void SaveBudgets(List<Budget> budgets, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Budget budget in budgets)
            {
                writer.WriteLine($"{budget.Category},{budget.Limit},{budget.Spent},{budget.Created}");
            }
        }
    }

    public static List<Budget> LoadBudgets(string filePath)
    {
        List<Budget> budgets = new List<Budget>();

        if (!File.Exists(filePath))
        {
            return budgets;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 4)
            {
                string category = parts[0];
                decimal limit = Convert.ToDecimal(parts[1]);
                decimal spent = Convert.ToDecimal(parts[2]);
                DateTime created = DateTime.Parse(parts[3]);

                Budget budget = new Budget(category, limit);
                budget.SetSpent(spent);
                budget.SetCreated(created);  
                budgets.Add(budget);
            }
        }
        return budgets;
    }
}