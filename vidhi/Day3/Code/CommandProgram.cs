using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgumentsDemo
{


    public struct Address
    {
        string state;
        string city;
        string subarea;
        string society;

    }

    class Program
    {
        static void Main(string[] args)
        {

            ViewNames("Ravi", "Rajiv", "Sachin");
            ViewNames("Seeta", "Geeta");
           

        }

        static void ViewNames(params string[] names)
        {
            Console.WriteLine("Names: {0}, {1}, {2}", names[0], names[1], names[2]);
        }

        static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Calculate(float radius, out float area, out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }

    }
}