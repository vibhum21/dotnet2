using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
    public class BillCL
    {
        public static List<Bill> GetAll()
        {
            List<Bill> bills = BillDAL.GetAll();


            return bills;
        }
        public static Bill Get()
        {
            Bill bill = BillDAL.Get(2);
            return bill; ;
        }
        public static void Insert()
        {
            Bill bill = new Bill(5, DateTime.Parse("8-Dec-15"), 450.0, 400, 3);
            BillDAL.Insert(bill);
            Console.WriteLine("Inserted");
        }
        public static bool Delete()
        {
            bool status = BillDAL.Delete(4);
            return status;
        }
        public static void Update()
        {
            Bill bill = new Bill(4,DateTime.Parse("3-Oct-15"),500.0000,400.0000,4);
            BillDAL.Update(bill);

        }
    }
}
