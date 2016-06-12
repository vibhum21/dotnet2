using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemoForDelegate
{
   public  delegate void TaxOperation();
    public class Account
    {
       public  event TaxOperation UnderBalance;
       public  event  TaxOperation OverBalance;
        float balance;
        public float Balance
        {
            get { return balance; }
            set { 
                balance = value; 
            }
        }
        public Account(float amount)
        {
            balance = amount;
        }
        public void Deposit(float amount)
        {            balance += amount;
            if (balance > 50000)
            {
                OverBalance();
            }
        }
        public void Withdraw(float amount)
        {  balance -= amount;
            if (balance < 10000)
            {
                UnderBalance();
            }
        }

    }
}
