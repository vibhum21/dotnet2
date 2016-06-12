using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
   public class Vehicle
    {
        public string vehicleNumber { get; set; }
        public int customerId { get; set; }
        public string company { get; set; }
        public string model { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(int cid, string vn, string cpy, string mdl)
        {
            this.vehicleNumber = vn;
            this.customerId = cid;
            this.company = cpy;
            this.model = mdl;
        }
        public override string ToString()
        {
            return "Vehicle Number : "+vehicleNumber+"\nCustomer ID : "+customerId+"\nCompany Name : "+company+"\nModel Name : "+model;
        }
    }
}
