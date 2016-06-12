using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class Person
    {
        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Person()
        {

        }
        public Person(string fn,string ln,DateTime bd,string em)
        {
            firstName = fn;
            lastName = ln;
            birthDate = bd;
            email = em;
        }
    }
}
    