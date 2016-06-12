using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
   partial class Employee
    {
        float basicSalary;

        public float BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        float hra;

        public float Hra
        {
            get { return hra; }
            set { hra = value; }
        }
        int da;

        public int Da
        {
            get { return da; }
            set { da = value; }
        }
        float tax;

        public float Tax
        {
            get { return tax; }
            set { tax = value; }
        }
       public virtual float ComputePay()
        {
            return basicSalary + hra + da - tax;
        }
    }
}
