using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoProblemWithCollection
{

    public class Person
    {
        string firstName;
        string lastName;
        string email;

    }
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList items = new ArrayList();
           List<int> items=new List<int>();
           List<string> names=new List<string>();
           List<Person> people=new List<Person>();
           Queue<Person> incomeTaxQuey = new Queue<Person>();

            for (int i = 0; i < 10000; i++)
            {
                items.Add(i);
                Person thePerson = new Person();
                people.Add(thePerson);
                incomeTaxQuey.Enqueue(thePerson);



            }
            //dfkjgkldfsg
            //sdkjflasjfasd

            for (int i = 0; i < items.Count; i++)
            {
                int value = items[i];
                Person thePerson = people[i];

                Console.WriteLine("Value is {0}", value);
            }
            Console.ReadLine();
        }
    }
}
