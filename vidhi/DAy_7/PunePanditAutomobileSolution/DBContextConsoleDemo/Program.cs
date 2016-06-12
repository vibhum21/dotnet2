using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBLLLib;
using WorkshopClLib;

namespace DBContextConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = CustomerContext.GetALL();
            foreach (Customer cst in customers)
            {
 
            }
           
        }
    }
}
