using System;

public class Budget
{
    private string _category;
    private decimal _limit;
    private decimal _spent;

    public Budget(string category, decimal limit)
    {
        _category = category;
        _limit = limit;
        _spent = 0;
    }

    public bool IsOverBudget()
    {
        return false; 
        // placeholder
    }
}