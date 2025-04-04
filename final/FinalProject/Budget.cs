public class Budget
{
    private string _category;
    private decimal _limit;
    private decimal _spent;
    private DateTime _created;

    public Budget(string category, decimal limit)
    {
        _category = category;
        _limit = limit;
        _spent = 0;
        _created = DateTime.Now;
    }

    public bool IsOverBudget()
    {
        return _spent > _limit;
    }

    public void AddSpending(decimal amount)
    {
        _spent += amount;
    }

    public void SetSpent(decimal amount)
    {
        _spent = amount;
    }

    public void SetCreated(DateTime created)
    {
        _created = created;
    }

    public DateTime Created {get {return _created;}}
    public string Category { get { return _category; } }
    public decimal Limit { get { return _limit; } }
    public decimal Spent { get { return _spent; } }
}