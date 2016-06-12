using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKeyWordsDemo
{
    class Program
    {
        static void ViewNames(params string[] names)
        {
            foreach(string s in names)
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
           ViewNames("Ravi","Rajiv","Sachin");
           ViewNames("fff","uyu");
            //Console.WriteLine(args[0]+args[1]+args[2]);
           int x = 10, y = 20;
           Swap(ref x, ref y);
            Console.WriteLine("x : "+x+" y : "+y);
           float area, circum;
           Calculate(5, out area, out circum);
           Console.WriteLine("Area : "+area+" Circum : "+circum);
           Console.WriteLine("parameter count={0}", args.Length);
           Console.WriteLine("Hello {0}", args[0]);
           Console.ReadLine();
        }
        static void Swap(ref int n1, ref int n2)
        {
            int temp=n1;
            n1=n2;
            n2=temp;
        }
        static void Calculate(float radius,out float area,out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }

        
    }
}