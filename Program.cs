var account1 = new BankAccount(1, "Khalid Abdi Guleid", 90);

account1.Withdraw(100);

// System.Console.WriteLine("Account Owner is: " + account1.Owner);
System.Console.Write("Account " + account1.AccountNumber + ": has a balance of: " + account1.Balance.ToString("C"));


// foreach (var transaction in account1.Transactions)
// {   
//     Console.WriteLine("Reference: " + transaction.Reference);
//     Console.WriteLine("Amount: " + transaction.Amount);
//     Console.WriteLine("Date: " + transaction.Date);
// }


// account1.AccountNumber = 1;
// account1.Owner = "Khalid Abdi Guleid";
// account1.Balance = 1000000;
