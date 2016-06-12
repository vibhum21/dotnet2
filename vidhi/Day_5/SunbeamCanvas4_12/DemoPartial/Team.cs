using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
   public  class Team
    {
       private Player[] players = new Player[11];

       public Team()
       {
       }

       public void ShowTeam()
       {
           foreach (Player thePlayer in players)
           {
               Console.WriteLine(thePlayer.Name);
           }
       }


       public Player this[int index]
       {
           get
           {
               return players[index];
           }
           set
           {
               players[index] = value;
           }
       }

    }

}
