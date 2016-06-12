using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
using System.Reflection;
using System.Collections;


namespace ReflectionDemo
{
    public class Player
    {
        string name;
        float runs;
        public string Name { get { return name; } set { name = value; } }
        public float Runs { get { return runs; } set { runs = value; } }
        public Player() {}
        public Player(string nm,float r)
        {
            name=nm;
            runs=r;
        }
    }

    public class Team: IEnumerable
{
        private Player [] players;
        public Team ()
        {
            players= new Player [4];
            players[0] = new Player ("Sachin", 40000);
            players[1] = new Player ("Rahul", 35000);
            players[2] = new Player ("Sourav", 34000);
            players[3] = new Player("MS", 34000);
}
       
    IEnumerator IEnumerable.GetEnumerator()
    {
 	    return players.GetEnumerator();
    }
}


    class Program
    {
        static void Main(string[] args)
        {
           Team India = new Team();
           foreach (Player plyr in India)
           {
               Console.WriteLine("Player Info{0}   {1}",plyr.Name, plyr.Runs.ToString());
           }
           Console.ReadLine();
     

        }
    }
}
