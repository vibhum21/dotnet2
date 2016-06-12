using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralGovernment
{
    class CentralGovt
    {
        delegate void TaxOperation();

        static void Main(string[] args)
        {
            Account acct = new Account(10000);
            CentralGovt gvt = new CentralGovt();
            acct.OverBalance += gvt.PayIncomeTax;
            acct.OverBalance += gvt.PayServiceTax;
            acct.OverBalance += gvt.PayLBT;
            acct.Deposit(10000);

        }
        void PayIncomeTax()
        {
            Console.WriteLine(" 45 % Income Tax have been deducted from your account");

        }
        void PayServiceTax()
        {
            Console.WriteLine("Service  Tax have been deducted from your account");

        }
        void PayLBT()
        {
            Console.WriteLine("from your account LBT have been deducted");

        }
    }
}
