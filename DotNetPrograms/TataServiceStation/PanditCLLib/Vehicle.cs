using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
   public class VehicleCL
    {
       public static List<Vehicle> GetALL()
       {
           List<Vehicle> vehicles = VehicleDAL.GetAll();
           return vehicles;

       }
       public static Vehicle Get()
       {
           Vehicle vehicle = VehicleDAL.Get(3);
           return vehicle;
       }
       public static void Insert(Vehicle vehicle)
       {
           VehicleDAL.Insert(vehicle);
           Console.WriteLine("Inserted");
       }
       public static bool Delete()
       {
           bool status = VehicleDAL.Delete(3);
           return status;
       }
       public static void Update(Vehicle vehicle)
       {
           VehicleDAL.Update(vehicle);
           Console.WriteLine("Updated");
       }
    }
}
