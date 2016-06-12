using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Person theperson = new Person();
            theperson.FirstName = "Ravi";
            theperson.LastName = "Tambade";
            Console.WriteLine(theperson.FirstName+" "+theperson.LastName);

            int count = 40;
            int* ptr = &count;
            int value = *ptr;
            Console.WriteLine("Age  is :" + value);
            Console.ReadLine();
        }
    }
}