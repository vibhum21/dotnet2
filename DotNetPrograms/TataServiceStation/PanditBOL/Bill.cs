using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime BillDate { get; set; }
        public Double Amount { get; set; }
        public Double AmountPaid { get; set; }
        public int CustomerID { get; set; }
        public Bill()
        {

        }
        public Bill(int bid,DateTime bd,double amt,double amtpd,int cid)
        {
            this.BillId = bid;
            this.BillDate = bd;
            this.Amount = amt;
            this.AmountPaid = amtpd;
            this.CustomerID = cid;
        }
        public override string ToString()
        {
            return BillId+" "+BillDate+" "+Amount+" "+AmountPaid+" "+CustomerID;
        }
    }
}
