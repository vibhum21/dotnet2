using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExplicitInterfaceDemo
{
    public interface IOrderDetails
    {
        void ShowOrderDetails();
    }

    public interface ICustomerDetails
    {
        void ShowCustomerDetails();
    }


    public class Transaction : IOrderDetails, ICustomerDetails
    {
        float amount;
        DateTime transDate;
        string fromAccount;
        string toAccount;
        public Transaction(string frmAcct, string toAcct, DateTime dt, float amount)
        {
           //initialize

        }
        public bool PerformTransaction()
        {
            bool status = false;
            //withdraw from source Account
            //deposit to destination Account
            //if successful then status is set to True;

            return status;

        }

        public void ShowOrderDetails()
        {
            Console.WriteLine("These are order Details");
        }

        public void ShowCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
