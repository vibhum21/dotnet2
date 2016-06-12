using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
  public  class Customer
    {
       
        public int customerId { get; set; }
	    public string name { get; set; }
	    public string address { get; set; }
	    public string mobile { get; set; }
        public double creditAmount { get; set; }

        public Customer()
        {
            
        }
        public Customer(string nm, string adr, string mb, double ca)
        {
            this.name = nm;
            this.address = adr;
            this.mobile = mb;
            this.creditAmount = ca;
        }
        public Customer(int cid,string nm,string adr,string mb,double ca)
        {
            this.customerId = cid;
            this.name = nm;
            this.address = adr;
            this.mobile = mb;
            this.creditAmount = ca;
        }
        public override string ToString()
        {
            return "Customer ID : "+customerId+ "\nName : " + name + "\nAddress : " + address + "\nMobile : " + mobile + "\nCredit Amount : " + creditAmount;
        }
    }
}
