class BankAccount
{
    public int AccountNumber { get; } // can only be gotten but not setted

    public string Owner { set; get; }

    public decimal Balance { get; private set; } // balance can't be setted it can only get from a withdraw or deposit

    // constructors are functions , mainly named as the Class name
    public BankAccount(int accountNumber, string owner, decimal initialBalance)
    {
        // to access a property use (this) or just call it
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = initialBalance;

    }

    // every account has two functions: deposit / withdrawal
    public void Deposit(decimal amount)
    {
        Balance += amount; 
    }
    public void Withdraw(decimal amount)
    {
        Balance -= amount; 
    }

}