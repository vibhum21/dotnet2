using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
   partial class Employee:Person
    {
       private int empID;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
       private string dept;

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        DateTime joinDate;

        public DateTime JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }
       public Employee():base()
        {

        }
       public Employee(string fn, string ln, DateTime bd, string em, int eid, string dpt, DateTime jd)
           : base(fn, ln, bd, em)
       {
           empID = eid;
           dept = dpt;
           joinDate = jd;
       }
       public override string ToString()
       {
           return base.ToString()+empID+dept+joinDate;
       }
    }
}
