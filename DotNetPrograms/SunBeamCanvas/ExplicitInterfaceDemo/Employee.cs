using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    class Employee:IPersonalDetails,IHRDetails
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
        void IHRDetails.ShowDetails()
        {
            Console.WriteLine("HR Employee Info");    
        }
        void IPersonalDetails.ShowDetails()
        {
            Console.WriteLine("Personal Info");    
        }
        void ComputePay()
        { }
        void PromoteEmployee()
        { }
        void PerformAppraisal()
        { }
    }
   
}
