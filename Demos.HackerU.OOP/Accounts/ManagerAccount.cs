using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.Accounts
{
    public class ManagerAccount : Account
    {
        public ManagerAccount(string fullName,
                               int accountNum,
                               double currentBalance,
                               string companyName)
                               :base(fullName, accountNum, currentBalance)

        {
            CompanyName = companyName;
        }

        public  string CompanyName { get; set; }
        

        public override double Deposit(double amount)
        {
            CurrentBalance += amount;
            return CurrentBalance;
        }

        public override double Withdraw(double amount)
        {
            CurrentBalance -= amount;
            return CurrentBalance;
        }
    }
}
