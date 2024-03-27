using System;

//Creating a class named BankAccount
class BankAccount
{    
    //Declaring the properties of the class  
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }
    public string AccountType { get; private set; }

    //Declaring the constructors 
    public BankAccount(int accountNumber, double initialBalane, string accountType = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = initialBalane;
        AccountType = accountType;
    }


    //Writing a method to deposit the money into the bank account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.Please enter a positive value.");
        }
    }

    //Writing another method to withdraw the money from the bank account
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}.New Balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
        }
    }

    //Testing the methods by passing the parameters into the constructors 
    static void Main()
    {
        BankAccount checkingAccount = new BankAccount(12345, 1000, "Checking");

        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(2000);

        BankAccount savingsAccount = new BankAccount(67850, 2000, "Savings");

        savingsAccount.Deposit(500);
        savingsAccount.Withdraw(1000);

    }
}
