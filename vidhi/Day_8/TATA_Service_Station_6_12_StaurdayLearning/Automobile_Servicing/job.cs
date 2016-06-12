using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile_Servicing
{
    public class job
    {
        string jobId;
        string title;
        string description;
        string jobCategory;
        


        public job()
        {
            this.jobId = "";
            this.title = "";
            this.description = "";
            this.jobCategory = "";

        }//End of ctor

        public job(string ID,string TITLE,string DESC,string CAT)
        {
            this.jobId = ID;
            this.title = TITLE;
            this.description = DESC;
            this.jobCategory =CAT;
        }//End of parameterized ctor


        public string Jobid
        {
            get { return jobId; }
            set { jobId = value; }
        }//property Jobid
       

        public string Title
        {
            get { return title; }
            set { title = value; }
        }//property of Title
        

        public string Description
        {
            get { return description; }
            set { description = value; }
        }//property of Description
        

        public string JobCategory
        {
            get { return jobCategory; }
            set { jobCategory = value; }
        }//property of JobCategory

        public override string ToString()
        {
            return jobId + " " + title + " " + description + " " + jobCategory;
        }//
       
    }//End of Class Name
}//End of Namespace
