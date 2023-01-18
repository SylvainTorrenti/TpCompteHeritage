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

        public SavingsAccount()
        {
            NbAccount += 1;
        }

        public SavingsAccount(int balance)
        {
            Balance = balance;
            NbAccount += 1;
        }
        public void ToString()
        {
            Console.WriteLine($"Le numero du compte : {AccountNB}");
            Console.WriteLine($"Le solde du compte est de : {Balance}");

        }
        public double CalculateInterest(SavingsAccount savingsAccount)
        {
            return Balance = Balance * 1.06;
        }
    }
}
