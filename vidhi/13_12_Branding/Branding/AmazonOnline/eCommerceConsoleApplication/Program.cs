using System;
using eCommerceBOL;
using eCommerceDAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment=PaymentDAL.Get(1);
            Console.WriteLine(payment);
            Console.Read();
        }
    }
}
