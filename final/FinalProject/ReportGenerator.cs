using System;

public class ReportGenerator
{
    public static void ShowSummary(List<Transaction> transactions)
    {
        decimal totalIncome = 0;
        decimal totalExpense = 0;

        foreach  (Transaction transaction in transactions)
        {
            if (transaction is Income)
            {
                totalIncome += transaction.Amount;
            }

            else if (transaction is Expense)
            {
                totalExpense += transaction.Amount;
            }
        }

        decimal netIncome = totalIncome - totalExpense;
        
        Console.WriteLine("=== Financial Summary ===");
        Console.WriteLine($"Total Income: {totalIncome:C}");
        Console.WriteLine($"Total Expenses: {totalExpense:C}");
        Console.WriteLine($"Net Income: {netIncome:C}");
    }
}