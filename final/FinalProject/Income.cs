using System;

public class Income: Transaction
{
    public Income(decimal amount, string category, DateTime date) 
    : base(amount, category, date)
    {

    }

    public override string GetTransactionType()
    {
        return "Income";
    }
}