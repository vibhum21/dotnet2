using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
    public class OilCL
    {
        public static List<Oil> GetAll()
        {
            List<Oil> oils = OilDAL.GetAll();

            return oils;
        }
        public static Oil Get()
        {
            Oil oil = OilDAL.Get(2);
            return oil; ;
        }
        public static void Insert()
        {
            Oil oil = new Oil(4,"Indian Oil" , 4, 400);
            OilDAL.Insert(oil);
            Console.WriteLine("Inserted");
        }
        public static bool Delete()
        {
            bool status = OilDAL.Delete(2);
            return status;
        }
        public static void Update()
        {
            Oil oil = new Oil(2, "Indian Oil", 5, 400.0000);
            OilDAL.Update(oil);

        }
    }
}
