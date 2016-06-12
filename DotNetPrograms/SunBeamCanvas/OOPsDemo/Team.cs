using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
   public class Team
    {
        private Player[] players = new Player[5];

        public Player[] Players
        {
            get { return players; }
            set { players = value; }
        }

        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
       public Team()
       {

       }
       public void showTeam()
       {
           foreach(Player thePlayer in players)
           {
               Console.WriteLine(thePlayer.Name);
           }
       }
       
    }
}
