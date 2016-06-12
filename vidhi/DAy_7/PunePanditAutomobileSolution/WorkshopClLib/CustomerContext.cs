using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBLLLib;
using WorkshopDALLib;

namespace WorkshopClLib
{
    public class CustomerContext
    {
        public static List<Customer> GetALL()
        {
            List<Customer> customers = CustomerDAL.GetAll();
            return customers;

        }

    }
}
