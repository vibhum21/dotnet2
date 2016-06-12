    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomGenerics
{
   public static class MyGenericMethods
    {
       public static void Swap<T>(ref T a,ref T b)
       {
           Console.WriteLine("You sent Swap( method a {0}", typeof(T));
           T temp; temp = a; a = b; b = temp;
       }
       public static void DisplayBaseClass<T>()
       {
           Console.WriteLine("Base class of {0} is : {1}.", typeof(T), typeof(T).BaseType);
       }
        //static void Main(string[] args)
        //{
        //    int a = 20, b = 40;
        //    Swap<int>(ref a, ref b);
        //    Console.WriteLine("After swap: {0}, {1}", a, b);
        //    string s1 = "Hello", s2 = "Vibhum";
        //    Swap<string>(ref s1, ref s2);
        //    Console.WriteLine("After swap: {0}, {1}", s1, s2);
        //    bool b1 = true, b2 = false;
        //    Swap(ref b1, ref b2);
        //    Console.WriteLine("After swap: {0}, {1}", b1, b2);
        //    DisplayBaseClass<int>();
        //    DisplayBaseClass<string>();
        //}
    }
}
