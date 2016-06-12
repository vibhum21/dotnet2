using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics
{

    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp; 
            temp = a; 
            a = b;
            b = temp;
        }
        public static void DisplayBaseClass<T>()
        { Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType); }

       static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");
            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();
            // Swap 2 strings.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0} {1}!", s1, s2);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
