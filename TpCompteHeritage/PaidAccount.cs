using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteHeritage
{
    internal class PaidAccount : Account
    {
        public PaidAccount()
        {
            NbAccount += 1;
        }

        public PaidAccount(int balance)
        {
            Balance = balance;
            NbAccount += 1;
        }
        public double Deposit(double amount)
        {
            Balance = Balance - 5;
            return Balance += amount;
        }
        public double Withdraw(double amount)
        {
            Balance = Balance - 5;
            return Balance -= amount;
        }
    }
}
