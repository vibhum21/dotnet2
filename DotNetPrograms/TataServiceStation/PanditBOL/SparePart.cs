using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanditBOLLib
{
    public class SparePart
    {
        public int SparePartId { get; set; }
	    public string Name { get; set; }
	    public int Quantity { get; set; }
        public float UnitPrice { get; set; }

        public SparePart()
        {
            this.SparePartId = 0;
            this.Name = "";
            this.Quantity =21;
            this.UnitPrice = 234.234f;

        }
        public SparePart(int sid,string name,int qty,float up)
        {
            this.SparePartId = sid;
            this.Name = name;
            this.Quantity = qty;
            this.UnitPrice = up;
        }
        public override string ToString()
        {
            return SparePartId + " " + Name + " " + Quantity + " " + UnitPrice;
        }
    }
}
