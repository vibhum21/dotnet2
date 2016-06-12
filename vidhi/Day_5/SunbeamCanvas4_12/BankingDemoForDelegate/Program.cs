using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemoForDelegate
{
    

    class CentralGovt
    {
        
        //declare 1
        delegate void  TaxOperation( );
        delegate int ArithmaticOperation(int num1, int num2);

        static void Main(string[] args)
        {
            Account acct123 = new Account(10000);
            CentralGovt modigvt = new CentralGovt();
            //added event handlers with event of acct123;

            acct123.OverBalance += modigvt.PayIncomeTax;
            acct123.OverBalance += modigvt.PayServiceTax;
            acct123.OverBalance += modigvt.PayLBT;
            
            acct123.Deposit(140000);

            float balance = acct123.Balance;
           // Console.WriteLine(balance);
            
           
            //register function with delegate
           // TaxOperation it = new TaxOperation(prg.PayIncomeTax);
            //TaxOperation svt = new TaxOperation(prg.PayServiceTax);
           // TaxOperation lbt = new TaxOperation(prg.PayLBT);
          
            //multicast Delegate

          //  TaxOperation govttax = it;
          //  govttax += svt;
          //  govttax += lbt;
          //  govttax();
            
            Console.ReadLine();

        }


        //according to delegate  implement functions 2

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

        int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        int Division(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
