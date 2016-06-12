using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Rajan";
            int count = 234;
            DateTime dt = DateTime.Now;



          object obj = dt;
         // int hashValue=obj.Equals()
       

            Console.ReadLine();

        }

       static  void Display(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
