using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteHeritage
{
    internal class Account
    {
        private static int _accountNb = 0;
        private double _balance;

        public static int AccountNb { get => _accountNb; private set => _accountNb = value; }
        public double Balance { get => _balance; private set => _balance = value; }

        public Account()
        {
            AccountNb += 1;
            Balance = 0;
        }

        public Account(int balance)
        {
            Balance = balance;
            AccountNb += 1;
        }

        public double Credit(double amount)
        {
            return Balance = amount;
        }
        public double Deposit(double amount) { }
    }
}
