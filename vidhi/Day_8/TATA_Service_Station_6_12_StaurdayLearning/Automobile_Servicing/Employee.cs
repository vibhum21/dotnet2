using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace Automobile_Servicing
{
    public class Employee:Person
    {
        string empID;
        DateTime joinDate;
        float tax;
        float da;
        int daysPresent;

        float bSalary;
        float hra;
        public Employee():base()
        {

            tax=500;
            da=450;
            daysPresent=20;
            bSalary=5000;
            hra=2500;
        }
        public Employee(string fname, string lname, int ag, DateTime bDate):base(fname,lname,ag,bDate)
        {

 
        }
        public virtual  float ComputePay()
        {
            return bSalary +( da * daysPresent) + hra - tax;

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
