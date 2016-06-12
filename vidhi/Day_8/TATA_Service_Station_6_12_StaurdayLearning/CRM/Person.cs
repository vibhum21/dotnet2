using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;
        DateTime birthdate;

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.birthdate = new DateTime(1990, 01, 07);
        } 
        public Person(string fname,string lname,int ag,DateTime birthday)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.age = ag;
            this.birthdate = birthday;
        }//End of parametrized ctor
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        } 
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        } 
        public DateTime birthDate
        {
            get { return this.birthdate; }
            set { this.birthDate = value; }
        }
        public override string ToString()
        {
            return firstName+ "  " +lastName + "  Age:"+ age ;
        }

        ~Person()
        {


        } 
    }
}
