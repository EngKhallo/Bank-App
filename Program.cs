var account1 = new BankAccount(1, "Khalid Abdi Guleid", 90);

account1.Withdraw(10);

System.Console.WriteLine("Account Owner is: " + account1.Owner);
System.Console.WriteLine("Account " + account1.AccountNumber + ": has a balance of: " + account1.Balance.ToString("C"));



// account1.AccountNumber = 1;
// account1.Owner = "Khalid Abdi Guleid";
// account1.Balance = 1000000;
