using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanditBOLLib;
using PanditDALLib;
namespace PanditCLLib
{
   public class JobCL
    {
       public static List<Job> GetAll()
        {
            List<Job> job = JobDAL.GetAll();
            return job;
        }
        public static Job Get()
        {
            Job job = JobDAL.Get(2);
            return job; ;
        }
        public static void Insert(Job job)
        {
            //Job job = new Job(3,"Manufacturing","Washing",DateTime.Now,"RJ12-HF-7654",450,6,3);
            JobDAL.Insert(job);
            Console.WriteLine("Inserted");
        }
        public static bool Delete()
        {
            bool status = JobDAL.Delete(2);
            return status;
        }
        public static void Update()
        {
            Job job = new Job(1, "	Manufacturing", "Tyres",DateTime.Now, "DL23-TH-4573", 600,4, 4);
            JobDAL.Update(job);

        }
    }
}
