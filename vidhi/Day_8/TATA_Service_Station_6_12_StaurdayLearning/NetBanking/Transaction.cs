using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking
{
    class Transaction
    {
        string transId;
        SavingAccount source;
        SavingAccount destination;
        float amount;
        DateTime transTime;
        public Transaction() { }
        public Transaction(SavingAccount s, SavingAccount d, float amt, DateTime  tTime) 
        {
           Guid newId= Guid.NewGuid();
           transId = newId.ToString();
           source = s;
           destination = d;
           transTime = tTime;
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        

        public string TransId
        {
            get { return transId; }
            set { transId = value; }
        }//End of property TransId
    }//End of Class
}// End of Namespace
