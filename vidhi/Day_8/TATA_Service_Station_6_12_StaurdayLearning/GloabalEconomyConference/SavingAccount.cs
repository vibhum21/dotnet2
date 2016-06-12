using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloabalEconomyConference
{
   public  class SavingAccount
    {
       //define memeber variables
        private float balance;
        private string id;

       //define constructors

        public SavingAccount()
        {
            this.balance = 0;
            this.id = "";
        }
        public SavingAccount(float amt, string _id)
        {
            this.balance = amt;
            this.id = _id;
        }


       //Add Deposit and withdraw methods
        public  void Deposit(float amount)
        { 
            //Write  Event Raising logic for condition
            //for Deposit method
            float tempBalance=balance + amount;
            if (tempBalance >= 100000)
            {
                balance += amount;
                    //raise Event
                    OverBalance();
            }
                else
                {
                    balance += amount;
                }
        }
        public  void Withdraw(float amount)
        { //Write  Event Raising logic for condition
            //for Withdraw method
        float tempBalance = balance - amount;
        if (tempBalance < 20000)
        {   //raise Event
            UnderBalance();
        }
        else
        {
            Balance -= amount;
        }
            
        }

       //Add  properties
        public float Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
       
       //define  UnderBalance and OverBalance Events

        public event taxDelegate UnderBalance;
        public  event taxDelegate OverBalance;

       ~SavingAccount()
        {

        } 
    } 
}
