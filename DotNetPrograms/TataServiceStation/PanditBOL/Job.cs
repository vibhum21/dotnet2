using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobType { get; set; }
        public string JobDescription { get; set; }
        public DateTime JobDate { get; set; }
        public string VehicleNumber { get; set; }
        public double ServiceCharge { get; set; }
        public int Quantity { get; set; }
        public int SparePartId { get; set; }
        public Job()
        {

        }
        public Job(int jid,string jt,string jd,DateTime jdt,string vn,double sc,int qty,int spid)
        {
            this.JobId = jid;
            this.JobType = jt;
            this.JobDescription = jd;
            this.JobDate=jdt;
            this.VehicleNumber = vn;
            this.ServiceCharge = sc;
            this.Quantity=qty;
            this.SparePartId = spid;
        }
        public override string ToString()
        {
            return JobId + " " + JobType + " " + JobDescription + " "+JobDate+" " + VehicleNumber + " " + ServiceCharge + " "+Quantity+" " + SparePartId;
        }
    }
}
