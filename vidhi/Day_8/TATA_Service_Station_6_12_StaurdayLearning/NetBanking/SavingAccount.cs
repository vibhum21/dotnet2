using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
namespace NetBanking
{
    class SavingAccount
    {
        private float balance;
        private string id;
        private Person owner;

        public SavingAccount()
        {
            this.balance = 0;
            this.id = "";
        }//En dof ctor

        public SavingAccount(float amt,string _id)
        {
            this.balance = amt;
            this.id = _id;
        }//End of parameterized ctor
        public SavingAccount(float amt,string _id,Person prn)
        {
            this.balance = amt;
            this.id = _id;
            Person owner = prn;
        }//End of parameterized ctor

        public bool Deposite(float amount)
        {
            this.balance += amount;
            return true;
        }//End of Deposite

        public bool Withdraw(float amount)
        {
            if (amount > this.balance)
                return false;
            else
            {
                this.balance -= amount;
                return true;
            }
        }//End of Withdraw

        public float Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }//Property of balance

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }//Property of ID

        ~SavingAccount()
        {

        }//End of dtor
    }//End of Class SavingAccount
}//End of Namespace
