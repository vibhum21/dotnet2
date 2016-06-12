using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Customer :Person
    {
        string rtoNumber;
        static int countCustomer;
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + rtoNumber;
        } 
        public Customer()
        {
            this.FirstName = "";
            this.LastName = "";
            this.rtoNumber = "";
            countCustomer++;
        } 
        public Customer(string fname,string lname,string rtoNo)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.rtoNumber = rtoNo;
            countCustomer++;
        }

        public Customer(string fname, string lname, int age, DateTime bDate,string rtoNo):base(fname,lname,age,bDate)
        {
            this.rtoNumber = rtoNo;
            countCustomer++;
        } 
        public static int GetCountCustomer()
        {
            return countCustomer;
        } 
        public string RtoNumber
        {
            get { return this.rtoNumber; }
            set { this.rtoNumber = value; }
        }
      
        ~Customer()
        {
            countCustomer--;
        } 
    } 
} 
