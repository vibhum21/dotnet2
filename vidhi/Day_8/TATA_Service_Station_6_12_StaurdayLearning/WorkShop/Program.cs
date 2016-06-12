using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using Automobile_Servicing;
using NetBanking;

namespace WorkShop
{
    class Program
    {
        /*
         * Entry point function for Console Application
         * 
         */

        static void Main(string[] args) 
        { 

            job job1=new  job();
            Guid newJbId = Guid.NewGuid();
            job1.Jobid=newJbId.ToString();
            job1.Title="EngineOil";
            job1.Description="Replace Engine Oil";
            job1.JobCategory="Engine";


            job job2=new  job();
            Guid newJb2Id = Guid.NewGuid();
            job1.Jobid=newJb2Id.ToString();
            job1.Title="Tyre";
            job1.Description="Replace Car  Tyre";
            job1.JobCategory="Wheel";
            

            //job[] jobs = new job[5];
            ArrayList jobs = new ArrayList();
            jobs.Add(job1);
            jobs.Add(job2);

            foreach(job currentJob in jobs)
            {
                Console.WriteLine(currentJob);
            }

             
            Console.ReadLine();

            
        } 
    } 
} 
