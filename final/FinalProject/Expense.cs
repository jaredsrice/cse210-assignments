using System;

public class Expense: Transaction
{
    public Expense(decimal amount, string category, DateTime date)
    : base (amount, category, date)
    {

    }

    public override string GetTransactionType()
    {
        return "Expense";
    }
}