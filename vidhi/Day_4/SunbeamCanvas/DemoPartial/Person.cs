using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
   public  class Person
    {
       protected string firstName;
       protected string lastName;
       protected  int age;

       internal int tokenNumber;

       public Person()
       {
 
       }
        public Person(string fname, string lname, int ag)
        {
            firstName = fname;
            lastName = lname;
            age = ag;
        }
        public virtual  string ShowDetails()
        {
            return firstName + " " + lastName + " " + age;

        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + age;

        }
    }
}
