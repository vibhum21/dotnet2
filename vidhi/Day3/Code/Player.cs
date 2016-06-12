using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
   public  class Player
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int score;
        DateTime joinDate;

        public Player(string nm, int sc, DateTime dtJoin)
        {
            name = nm;
            score = sc;
            joinDate = dtJoin;
        }
    }
}
