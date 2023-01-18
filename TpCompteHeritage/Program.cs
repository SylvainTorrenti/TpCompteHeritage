using TpCompteHeritage;

#region Create 1 account
Account Account1 = new Account();
Account1.ToString(); 
#endregion
Console.WriteLine("*************");
#region Create 2 account
Account Account2 = new Account(25000);
Account2.ToString(); 
#endregion
Console.WriteLine("*************");
#region Withdraw
Console.WriteLine($"Le solde du compte 1 aprés un retrait de 5000 euros : {Account1.Withdraw(5000)}");
Console.WriteLine("*************");
Console.WriteLine($"Le solde du compte 2 aprés un retrait de 5000 euros : {Account2.Withdraw(5000)}"); 
#endregion
Console.WriteLine(" *************");
#region Deposit
Console.WriteLine($"Le solde du compte 1 aprés un depot de 15000 euros : {Account1.Deposit(15000)}");
Console.WriteLine("*************");
Console.WriteLine($"Le solde du compte 1 aprés un depot de 15000 euros : {Account2.Deposit(15000)}");
#endregion
Console.WriteLine("*************");
#region Saving Account
SavingsAccount SavingsAccount1 = new SavingsAccount(30000);
SavingsAccount1.ToString();
Console.WriteLine("*************");
Console.WriteLine($"Le solde du compte epargne aprés calcul des interet : {SavingsAccount1.CalculateInterest(SavingsAccount1)}");
#endregion
Console.WriteLine("*************");
#region Paid account
PaidAccount PaidAccount1 = new PaidAccount(50000);
PaidAccount1.ToString();
Console.WriteLine("*************");
Console.WriteLine($"Le solde compte payant aprés un depot de 10 000 est : {PaidAccount1.Deposit(10000)}");
Console.WriteLine("*************");
Console.WriteLine($"Le solde compte payant aprés un retrait de 10 000 est :{PaidAccount1.Withdraw(10000)}"); 
#endregion