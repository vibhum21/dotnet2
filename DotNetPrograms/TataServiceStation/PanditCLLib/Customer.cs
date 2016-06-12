using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
   public class CustomerCL
    {
       public static List<Customer> GetAll()
       {
           List<Customer> customers = CustomerDAL.GetAll();
          

           return customers;
       }  
       public static Customer Get(Customer customer)
       {
          // Customer customer = CustomerDAL.Get(2);
           return customer;
       }
     
       public static void Insert(Customer customer)
       {
           
           CustomerDAL.Insert(customer);
           Console.WriteLine("Inserted");
       }
       public static bool Delete()
       {
           bool status = CustomerDAL.Delete(9);
           return status;
       }
       public static void  Update()
       {
           Customer customer=new Customer(6,"Vinay","Rajasthan","2345343763",634);
           CustomerDAL.Update(customer);
           
       }
    }
}
