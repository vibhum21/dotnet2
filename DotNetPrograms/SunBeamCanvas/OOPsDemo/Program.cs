using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            myTeam[0] = new Player("Vibhum", 1343566, DateTime.Now);
            myTeam[1] = new Player("Agarwal",343566, DateTime.Now);
            myTeam[2] = new Player("Ayush", 234566, DateTime.Now);
            myTeam[3] = new Player("Sachin", 2343566, DateTime.Now);
            myTeam[4] = new Player("Sourabh", 233566, DateTime.Now);
            //myTeam[1].Name=("Vibhum");
            Array.Sort(myTeam.Players);
            myTeam.showTeam();
          //  myTeam.showTeam();
           // Person p = new Manager();
           //Person p1 = new Employee("vibhum", "agarwal", DateTime.Parse("21-02-1993"), "vibhum1993@gmail.com", 10308, "MGR", DateTime.Now);
           // p = new Manager("vibhum", "agarwal", DateTime.Parse("21-02-1993"), "vibhum1993@gmail.com", 10308, "MGR", DateTime.Now, 234.50f);
           // if(p1 is Manager)
           // {
           //     Console.WriteLine("p1 is Manager");
           // }
           // else
           // {
           //     Console.WriteLine("p1 is not Manager");
           // }
           // Person mgr = new Manager();
           // Manager mgr2 = mgr as Manager;
        }
    }
}
