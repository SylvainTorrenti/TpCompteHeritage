using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteHeritage
{
    internal class Account
    {
        #region Attribute
        private static int _nbAccount = 0;
        private double _balance;
        private double _accountNB;

        #endregion
        #region Get & Set AccountNb
        public static int NbAccount { get => _nbAccount; set => _nbAccount = value; }
        #endregion
        #region Get & Set Balance
        public double Balance { get => _balance; set => _balance = value; }
        #endregion
        #region Get & Set AccountNB
        public double AccountNB { get => _accountNB; set => _accountNB = value; }
        #endregion
        #region Constructor
        public Account()
        {
            NbAccount += 1;
            Balance = 0;
            AccountNB = NbAccount;
        }

        public Account(int balance)
        {
            Balance = balance;
            NbAccount += 1;
            AccountNB = NbAccount;
        }
        #endregion
        #region Method
        public double Deposit(double amount)
        {
            return Balance += amount;
        }
        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }
        public void ToString()
        {
            Console.WriteLine($"Le numero du compte : {AccountNB}");
            Console.WriteLine($"Le solde du compte est de : {Balance}");
        } 
        #endregion
    }
}
