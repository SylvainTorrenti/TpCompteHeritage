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
Account1.Withdraw(5000);
Account2.Withdraw(5000);
Account1.ToString();
Console.WriteLine("*************");
Account2.ToString();
#endregion
#region Deposit
Account1.Deposit(15000);
Account2.Deposit(15000);
Account1.ToString();
Console.WriteLine("*************");
Account2.ToString(); 
#endregion