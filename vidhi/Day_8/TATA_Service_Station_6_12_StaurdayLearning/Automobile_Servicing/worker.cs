using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Automobile_Servicing
{
    public class worker:Employee
    {
        string workerId;
        string jobProfile;
        float incentive;
        public worker():base()
        {
            incentive = 4000;
            this.workerId = "";
           this.jobProfile = "";
        }//End of ctor
        public worker(string fname, string lname, int ag, DateTime bDate, float bSal, string ID,string Profile):base()
        {
            this.workerId = ID;
         
            this.jobProfile = Profile;
        }//End of parameterized ctor
        public string JobProfile
        {
            get { return jobProfile; }
            set { jobProfile = value; }
        }//Property of Jobprofile
        public string WorkerId
        {
            get { return workerId; }
            set { workerId = value; }
        }//Property of workerId
        ~worker()
        {
            this.workerId = "";
            this.jobProfile = "";
        }//End of dtor
        public override float ComputePay()
        {
            return base.ComputePay() + incentive;
        } 
    }//End of Class worker
}//End of Namespace Automobile_Servicing
