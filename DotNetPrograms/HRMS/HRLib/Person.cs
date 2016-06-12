using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Person
    {
        private String firstName;
        private String lastName;
        DateTime birthdate;
        string email;
        string address;
        static int count;
        public Person(string firstName,string lastName,DateTime birthdate,string email,string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.email = email;
            this.address = address;
            count++;
        }
        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.birthdate = DateTime.Parse("21-02-1993");
            this.email = "";
            this.address = "";
            count++;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public void showFullName()
        {
            Console.WriteLine(firstName + lastName);   
        }
        public int GetAge()
        {
            DateTime date = DateTime.Now;
            DateTime birthdate = DateTime.Parse("21 - 02 - 1993");
            return (date.Year-birthdate.Year);
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
