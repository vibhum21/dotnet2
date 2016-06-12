using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        enum Weekdays { Mon, Tue, Web, Thu, Fri, Sat };

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine ("parameter count = {0})", args.Length);
            
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Hello {0}", args[i]);
            int x=543454;
            long y=x; //implicit conversion
            short z= (short) x; //explicit conversion
            double d=1.3454545345;
            float f= (float) d; //explicit conversion
            long l = (long)d; // explicit conversion


            //Weekdays dayofWeek = Weekdays.Mon;
            


            Console.ReadLine ();
        }
    }
}

 