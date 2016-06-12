using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Servicing
{
    public class jobcard
    {
        string jobCardId;
        DateTime endTime;
        string status;
        Vehicle vehicle;
        DateTime startTime;
        job [] jobs= new job[5];
        int jobIndex = 0;

        public jobcard()
        {
            this.jobCardId = "";
            this.status = "";
            this.endTime = DateTime.Now;
            this.startTime = DateTime.Now;
        }//End of ctor

        public jobcard(string ID,string status,DateTime strtTime,DateTime EndTime)
        {
            this.jobCardId = ID;
            this.status = status;
            this.endTime = EndTime;
            this.startTime = strtTime;
        }//End of ctor with parameterized*/


        public string JobCardId
        {
            get { return jobCardId; }
            set { jobCardId = value; }
        }//property JobCardId
        

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }//property JobStartTime
      
        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }//property EndTime
        
        public string Status
        {
            get { return status; }
            set { status = value; }
        }//property JobStatus1


        public Vehicle ServiceVehicle
        {
            set { this.vehicle = value; }
            get { return vehicle; }
        }

        public override string ToString()
        {
            return  jobCardId + " " + status + " " + startTime + " " + endTime;

        }//
        ~ jobcard()
        {}//End of dtor
       
        public string StartServicing()
        {
            job engineServicingJob = new job();
            engineServicingJob.Title = "Replace Enging Oil ";
            engineServicingJob.Description = "Engine Oil need to be changed after 6000 Km";
            engineServicingJob.JobCategory = "Engine";
            Guid newGuid = Guid.NewGuid();
            engineServicingJob.Jobid = newGuid.ToString();
            this.jobs[0] = engineServicingJob;
            Status = "Inprogress";
            return Status;
        }
        public string GetServiceStatus()
        {
            return Status;

        }

        public int GetJobCount()
        {
            return jobIndex;
        }
        public void AddJob(job job)
        {
            if (jobIndex < 5)
            {
                this.jobs[jobIndex] = job;
                jobIndex++;
            }

        }
        public void RemoveJob(job job)
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i].Title == job.Title)
                {
                    this.jobs[i] = null;
                    break;

                }
                
            }
                

        }

    }//End of Class jobcard
}//End of Automobile_Servicing
