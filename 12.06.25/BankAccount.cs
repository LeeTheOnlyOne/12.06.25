using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._06._25
{
    internal class BankAccount
    {
        private int id;
        private double balance;

        public int ID { get; set; }
        public double Balance { get; set; }

        void Deposit(double amount)
        {
            if (amount < 0)
            {
                amount += balance;
            }

        }

        void Withdraw(double amount)
        {
            if (amount < 0)
            {
                amount -= balance;
            }
            
        }
    }
}
