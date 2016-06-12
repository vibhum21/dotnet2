    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    sealed class Manager : Employee
    {
        float incentive;

        public float Incentive
        {
            get { return incentive; }
            set { incentive = value; }
        }
        public override string ToString()
        {
            return base.ToString() + incentive;
        }
        public override float ComputePay()
        {
            return base.ComputePay() + this.incentive;
        }
        public Manager()
            : base()
        {

        }
        public Manager(string fn, string ln, DateTime bd, string em, int eid, string dpt, DateTime jd, float inc)
            : base(fn, ln, bd, em, eid, dpt, jd)
        {
            incentive = inc;
        }
    }
}
