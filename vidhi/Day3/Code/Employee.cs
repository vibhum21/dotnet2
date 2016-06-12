using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{

    //Personal information about Employee

    partial  class Employee:Person
    {
       
        string email;

        public Employee():base()
        { 
        }

        public Employee(string fname, string lname, int ag, string em):base(fname,lname,ag)
        {
            email = em;
           
        }
        public override  string ShowDetails()
        {
            return base.ShowDetails() + " " + email;
        }

        public override string ToString()
        {
            return base.ToString() + "  " + email;
        }
    }
}
