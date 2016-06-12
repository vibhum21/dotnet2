using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vibhum","Agarwal",DateTime.Parse("21-02-1993"),"vibhum1993@gmail.com","Pune");
            Person person1 = new Person();
            person.FirstName = "Vibhum ";
            person.LastName = "Agarwal";
           // person.showFullName();
            DateTime date = DateTime.Now;
            
            Console.WriteLine(Person.GetCount());
              
        }
    }
}
