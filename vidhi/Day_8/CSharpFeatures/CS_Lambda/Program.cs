using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Lambda
{
    public delegate int MyDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            //x=>x+10 : x goes into(=>) method and return x+10
         //   Console.WriteLine(" Accept Change :" + AcceptChange(10));
          //  Console.WriteLine(" Basic Change :" + BasicChange(x => x + 10));
          //  Console.WriteLine(" First Change :" + FirstChange(x => x + 10, 20));  
         // Console.WriteLine(" Second Change :" + SecondChange(x=>x+10, 20,30) );  
         

            Console.ReadLine();  
        }

        private static int AcceptChange(int x)
        {
            return x + 10;
        }

       
        public static int FirstChange(MyDelegate d, int x)
        {
            //MyDelegate d =   delegate(int z)
            //{
            //    return z+10;
            //};


            return d(x) + x;
        }

        public static int SecondChange(MyDelegate d, int x, int y)
        {
            //MyDelegate d =   delegate(int z)
            //{
            //    return z+10;
            //};
                
            
            return d(x) + x + y; 
        }

        static int DoWork(int x)
        {
            return x * 10;
        }

    }
}
