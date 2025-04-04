using System;

public class Transaction
{
   protected decimal _amount;
   protected string _category;
   protected DateTime _date;


   public Transaction( decimal amount, string category, DateTime date)
   {
        _amount = amount;
        _category = category;
        _date = date;
   }

   public virtual string GetTransactionType()
   {
        return "Transaction";
   }

   public void Display()
   {
     Console.WriteLine($"{GetTransactionType()} - {Amount:C} - {Category} - {Date}");
   }

   public decimal Amount
   {
     get {return _amount;}
   }

   public string Category
   {
     get {return _category;}
   }

   public DateTime Date
   {
     get {return _date;}
   }
}