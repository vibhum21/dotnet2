using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            IPersonalDetails iPr = emp;
            iPr.ShowDetails();

            IHRDetails iHr = emp;
            iHr.ShowDetails();
        }
    }
}
