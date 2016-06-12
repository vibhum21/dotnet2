using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpInterfaceDemo
{
    interface IPersonalDetails
    {
        void ShowDetails();

    }
    interface IHRDetails
    {
        void ShowDetails();
    }

    class Employee : IPersonalDetails,IHRDetails
    {
        //Personal Point of view
        string firstName;
        string lastName;
        string email;
        DateTime birthdate;

        //HR Point of view
        float basicSalary;
        float da;
        float hra;
        float tax;
        public Employee()
        {
 
        }
        void IPersonalDetails.ShowDetails()
        {
            Console.WriteLine("Personal Info");    
        }
        void IHRDetails.ShowDetails()
        {
            Console.WriteLine("HR Employee Info");
        }
        void ComputePay()
        { }
        void PromoteEmployee()
        { }
        void PerformAppraisal()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
           // IPersonalDetails iPr = emp;
           // iPr.ShowDetails();

            IHRDetails iHr = emp;
            iHr.ShowDetails();


        }
    }
}
