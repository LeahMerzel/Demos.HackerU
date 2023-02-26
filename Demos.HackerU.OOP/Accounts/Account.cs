using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Accounts
{
    public abstract class Account
    {
        public string FullName { get; set; }
        public int AccountNum { get; set; }
        public double CurrentBalance { get; set; }

        public abstract double Deposit(double amount);
        public abstract double Withdraw(double amount);

        public Account(): this("",-1,0)
        {
            
        }

        public Account(string fullName, int accountNum, double currentBalance)
        {
            FullName = fullName;
            AccountNum = accountNum;
            CurrentBalance = currentBalance;
        }
    }
}
