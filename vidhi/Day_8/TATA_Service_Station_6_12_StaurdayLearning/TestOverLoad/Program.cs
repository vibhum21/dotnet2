using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOverLoad
{
    class Program
    {
     static void Main ( string[ ] args )
    {
        Complex o1 = new Complex(1,1);
        Console.WriteLine("First return the value and then set Value");

        Complex o2 = o1++;
        Console.WriteLine(" Object O1 : "+ o1.imag + " : " + o1.real);
        Console.WriteLine(" Object O2 : " +o2.imag + " : " + o2.real);

        Console.WriteLine("First set Value and then return");
         o2 = ++o1;
        Console.WriteLine(" Object O1 : "+ o1.imag + " : " + o1.real);
        Console.WriteLine(" Object O2 : " +o2.imag + " : " + o2.real);
        Console.Read();
    }
        }
    }

 public    class Complex
{
    public int imag;
    public int real;

    public Complex ( int ig, int rl)
    {
        this.imag = ig;
        this.real = rl;
    }
    public static Complex operator ++(Complex arg )
    {
        arg.imag++;
        arg.real++;
        return arg;
    }
}
 
 
