using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
    public class SparePartCL
    {
        public static List<SparePart> GetAll()
        {
            List<SparePart> sparepart = SparePartDAL.GetAll();
            return sparepart;
        }
        public static SparePart Get(int id)
        {
           // SparePart sparepart = SparePartDAL.Get(2);
            SparePart sp=SparePartDAL.Get(id);
            return sp ;
        }
        public static void Insert(SparePart sparepart)
        {
            //SparePart sparepart = new SparePart(3, "Washing",5, 300);
            SparePartDAL.Insert(sparepart);
            Console.WriteLine("Inserted");
        }
        public static bool Delete()
        {
            bool status = SparePartDAL.Delete(2);
            return status;
        }
        public static void Update()
        {
            SparePart sparepart = new SparePart(1, "Tyres",6, 400);
            SparePartDAL.Update(sparepart);

        }
    }
}
