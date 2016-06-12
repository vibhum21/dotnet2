using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloabalEconomyConference
{

    //step 1 : Define Delegate

   public  delegate  void taxDelegate();
   public  delegate void  allowanceDelegate();
   public  delegate void  penaltyDelegate();

    class Program
    {

        //Write Event Handlers

        //Tax policies
      public   static void PayIncomeTax()
        {
            Console.WriteLine("Income tax has been deducted from your Account");

        }
      public static void PayServiceTax()
      {
          Console.WriteLine("Service Tax has been deducted from your Account");

        }
      public static void PayLBTTax()
        {
            Console.WriteLine("LBT tax has been deducted from your Account");

        }
      public static void PaySalesTax()
        {
        }
      public static void PayMovieTax()
        {
        }
   
        //Helping BPL Citizen
      public static void LPGSubsidi() { }
      public static void FuelAllowance() 
      {
          Console.WriteLine("1500 Rupees have been added to your  Account");

      }
      public static void DiscountHomePurchase() { }

        //Penalty
    public static void PenaltyForLessamount()
    {
        Console.WriteLine(" you have been charged 500 Rupees for less Balance");
        Console.WriteLine("Rupees 500 will be deducted once balance will be more than 20000");

    }


        static void Main(string[] args)
        {
            //State Government
            //Create object of Account class
            SavingAccount acct1 = new SavingAccount(225000,"acct786");
  
            //Register  Event handlers with Event of the object
            //Test 
            acct1.UnderBalance += Program.PenaltyForLessamount;
            acct1.OverBalance += Program.PayIncomeTax;
            acct1.OverBalance += Program.PayLBTTax;
            acct1.OverBalance += Program.PayServiceTax;
            acct1.OverBalance += Program.PayMovieTax;
            acct1.Deposit(2000);
            Console.ReadLine();


        }
    }
}
