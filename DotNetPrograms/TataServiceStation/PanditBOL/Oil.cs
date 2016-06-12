using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
   public class Oil
    {
       public int OilId { get; set; }
       public string Title { get; set; }
       public int Quantity { get; set; }
       public double Price { get; set; }
       public Oil()
       {

       }
       public Oil(int oid,string tle,int qty,double prc)
       {
           this.OilId = oid;
           this.Title = tle;
           this.Quantity = qty;
           this.Price = prc;
       }
       public override string ToString()
       {
           return OilId + " " + Title + " "+Quantity+" " + Price;
       }
    }
}
