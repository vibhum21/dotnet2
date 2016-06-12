using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemo
{

    public class OfficeBoy
    {
        private static OfficeBoy _ref = null;
        private int _val;
        private OfficeBoy() { _val = 10; }
        public int Val
        {
            get { return _val; }
            set { _val = value; }
        }
        public static OfficeBoy GetObject()
        {
            if (_ref == null)
                _ref = new OfficeBoy();
            return _ref;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OfficeBoy sweeper, waiter;
            string s1; float f1;
            sweeper = OfficeBoy.GetObject();
            waiter = OfficeBoy.GetObject();
            sweeper.Val = 60;
            Console.WriteLine("Sweeper Value : {0}", sweeper.Val);
            Console.WriteLine("Waiter Value : {0}", waiter.Val);
            s1 = sweeper.Val.ToString();
            f1 = (float)sweeper.Val;
            sweeper.Val = int.Parse(s1);
            sweeper.Val = Convert.ToInt32(s1);

            Console.ReadLine();

        }
    }
}
