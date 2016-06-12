using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenDemo
{
    class Program
    {
        //step 1
        delegate string DetailsOperation(string customer);
 
        public static  string GetOrderDetails(string customer)
        {
            return "Customer= "+ customer +" Order Details : Order ID=23";
        }

        public  static string GetPaymentDetails(string customer)
        {
            Console.WriteLine( "Customer= "+ customer +" :-->Payment Details : Transaction ID=23, Invoice=invc_transflower");
            return customer;

        }

        public static string GetCustomerPersonalDetails(string customer)
        {
            Console.WriteLine( "Customer= " + customer + " :First Name :, LastName=");
            return customer;

        }
        static void Main(string[] args)
        {
            //early binding of function 
          // string details= GetOrderDetails("Rajiv");
          
           // Step 2
           //Creating an instance of delegate and
            //register delegate with function 
                   //which will be called at runtime

            DetailsOperation dlgt1 = new DetailsOperation(GetOrderDetails);
            DetailsOperation dlgt2 = new DetailsOperation(GetPaymentDetails);
            //Step 3
            //late binding
            //Rutime Invocation
            DetailsOperation dlgt = dlgt1;
            dlgt += dlgt2;

            string details = dlgt("Sandeep");


            dlgt -= dlgt2;

            Console.WriteLine(details);

            Console.ReadLine();
        }
    }
}
