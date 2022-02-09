class BankAccount
{

    // public string[] Transactions { get; set; }

    public int AccountNumber { get; } // can only be gotten but not setted

    public string Owner { set; get; }

    public decimal Balance { get; private set; } // balance can't be setted it can only get from a withdraw or deposit

    public Transaction[] Transactions { get; set; } = new Transaction[1];

    // constructors are functions , mainly named as the Class name
    public BankAccount(int accountNumber, string owner, decimal initialBalance, string accountTransactions)
    {
        // to access a property use (this) or just call it
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = initialBalance;
        Transactions = accountTransactions;
    }

    // every account has two functions: deposit / withdrawal
    public void Deposit(decimal amount)
    {
        Balance += amount;

        var transaction = new Transaction()
        {
            Reference = 1,
            Amount = amount,
            Date = DateTime.Now
        };

        Transactions[0] = transaction;

    }
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            System.Console.WriteLine("Hadhaagaagu Kuguma Filna!");
            return;
        }
        else
        {
            Balance -= amount;
            // System.Console.WriteLine("Waxaad la baxday: " + Balance);
        }
    }

}