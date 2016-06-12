using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    class Program
    {

        public int? numericValue = null;
        public bool? boolValue = true;

        static void Main(string[] args)
        {
            Books myBooks = new Books();
            string title=myBooks[1];
            myBooks[6] = "Harry Potter";

            Team indianTeam = new Team();
            indianTeam[0] = new Player("Sachin",100000,DateTime.Now);
            indianTeam[1] = new Player("Sourav", 10000, DateTime.Now);



            int[,] mtrx = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };


            int [ ] [ ] mtrxj = new int [2] [];

            Employee emp = new Employee("rajan", "patil", 24, "rajan.patil@gamil.com");

            if (emp is Person)
            {

            }
            else
            { 
            }

            Person mgr = new Manager();
            Manager mgr2 = mgr as Manager;


        }

    }
}
