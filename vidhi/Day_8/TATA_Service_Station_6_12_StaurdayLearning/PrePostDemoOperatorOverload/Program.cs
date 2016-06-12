using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrePostDemoOperatorOverload
{
  class Complex
  {
       public   int real;
       public int imag;
        public Complex ()
        {
            real = 0;
            imag = 0;

        }
        public Complex(int r,int i)
        {
            real=r;
            imag = i;
        }
        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex c = new Complex();
            c.real = c1.real + c2.real;
            c.imag = c1.imag + c2.imag;

            return c;
        }
        public static Complex operator ++(Complex c1)
        {
            Complex c = new Complex();
            c.real = c1.real + 1;
            c.imag = c1.imag + 1;
            return c;
           // c1.real++;
           // c1.imag++;
           // return c1;
        }

  }
 
 class Program
    {
        static void Main(string[] args)
        {
            
           /* int a = 1;
            int b = a++;
            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);

            Console.WriteLine("Pre increment");
            int c = 1;
            int d = ++c;
            Console.WriteLine("A= " + c);
            Console.WriteLine("B= " + d);

            Console.ReadLine();
            */

           
            Complex c1 = new Complex(10, 10);
            Complex c2 = c1++;
            Console.WriteLine("Post increment");
            Console.WriteLine(" Value of C1 =" + c1.real + " : " + c1.imag);
            Console.WriteLine(" Value of C2 =" + c2.real + " : " + c2.imag);

            Complex c3 = new Complex(50, 50);
            Complex c4 = ++c3;

            Console.WriteLine("   ");
            Console.WriteLine("Pre increment");
            Console.WriteLine(" Value of C3 =" + c3.real + " : " + c3.imag);
            Console.WriteLine(" Value of C4 =" + c4.real + " : " + c4.imag);

            Console.ReadLine();
              


        }
    }
}
