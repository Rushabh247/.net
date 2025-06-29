using System;
class BankAccount
{
    private string accountHolder;
    private double balance;

    public BankAccount(string accountHolder , double balance)
    {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public void withdraw(double value)
    {
        balance -= value;
    }

    public void deposit(double value)
    {
        balance += value;
    }
    public void modifyBalance() {
        double value = 0;
        Console.WriteLine("Withdraw or Deposit (w/d)");
        char action = Convert.ToChar(Console.ReadLine());
        if (action == 'w')
        {
            Console.WriteLine("Enter amount");
            value = Convert.ToDouble(Console.ReadLine());
            balance -= value;
        }

        else if
            (action == 'd')
        {
            Console.WriteLine("Enter amount");
            value = Convert.ToDouble(Console.ReadLine());
            balance += value;
        }
        else Console.WriteLine("enter valid action");


    }
    public static void Main (string[] args)
    {
        BankAccount b1 = new BankAccount("ram", 2000);
        BankAccount b2 = new BankAccount("rushabh", 2000);
        Console.WriteLine("for account no 1");
        Console.WriteLine();
        for (int i = 0; i < 3; i++) { 
        b1.modifyBalance();
        
        }
        Console.WriteLine("for account no 2");
        for (int i = 0; i < 3; i++)
        {
            b2.modifyBalance();

        }
        Console.WriteLine();
        if (b1.balance > b2.balance)
        {
            Console.WriteLine("b1 wins !!");

        }
        else Console.WriteLine("b2 wins !!");

    }


}