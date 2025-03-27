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

// Add dislay method and getter methods 

}