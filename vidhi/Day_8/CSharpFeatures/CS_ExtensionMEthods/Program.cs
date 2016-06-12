using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ExtensionMEthods
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator m = new Calculator();
            
            Console.WriteLine("Addition=  " + m.Addition(2,3) );
            Console.WriteLine("Subtraction=  " + m.Subtraction(2, 3));
            Console.WriteLine("Multiplication= " + m.Multiplication(3,4));
            string s = "Doing Ordinary Things Extra Ordinarily: Ravi Tambade";
           
            Console.WriteLine("Lenght of " + s + " is = " + s.CalculateStringLenght(s));  
            Console.ReadLine();  
        }
    }

    public sealed class Calculator
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Subtraction(int x, int y)
        {
            return x - y;
        }
    }

 
    public static class MyExtensionClass
    {
        public static int Multiplication(this Calculator m,int x,int y)
        {
            return x * y;
        }
       
        public static int CalculateStringLenght(this string s, string str)
        {
            int lenght = 0;
            foreach (char c in str)
            {
                lenght++;
            }
            return lenght;
        }
    }



}
