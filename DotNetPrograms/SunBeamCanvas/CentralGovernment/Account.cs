using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralGovernment
{
    public delegate void TaxOperation();
    class Account
    {
        public event TaxOperation OverBalance;
        public event TaxOperation UnderBalance;
        float balance;

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account(float amount)
        {
            balance = amount;
        }
        public void Deposit(float amount)
        {
            balance += amount;
            if (balance > 100000)
                OverBalance();
        }
        public void WithDraw(float amount)
        {
            balance -= amount;
            if (balance < 5000)
                UnderBalance();
        }

    }
}
