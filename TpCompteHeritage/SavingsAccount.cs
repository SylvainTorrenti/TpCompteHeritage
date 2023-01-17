using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteHeritage
{
    internal class SavingsAccount : Account
    {
        private int _interest = 6;

        public int Interest { get => _interest; set => _interest = value; }

        public SavingsAccount(Account account)
        {
            Balance = account.Balance;
            AccountNB = account.AccountNB;
        }
        public void ToString()
        {
            Console.WriteLine($"Le numero du compte : {AccountNB}");
            Console.WriteLine($"Le solde du compte est de : {Balance}");
          
        }
    }
}
