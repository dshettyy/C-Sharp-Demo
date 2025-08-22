using System;

namespace Bank
{
    class Account
    {
     protected string Account_Name;  
     protected string Account_ID;
     protected float balance;

     public Account(string acc_number , string Acc_id, int bal)
        {
            Account_Name = acc_number;
            Account_ID = Acc_id;
            balance = bal;
        }
       public virtual void Deposit(float amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount Deposited");
            Console.WriteLine("Current Balance:" + balance);
        }
    }

    class Program
    {
        static void Main()
        {
            Account ac = new Account("Boss","DS1001",5000);
            ac.Deposit(1000);
        }
    }
}