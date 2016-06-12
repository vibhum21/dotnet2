using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    public class Player:IComparable
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int runs;

        public int Runs
        {
            get { return runs; }
            set { runs = value; }
        }
        DateTime joinDate;
        public Player(string nm,int sc,DateTime dtJoin)
        {
            name = nm;
            runs = sc;
            joinDate = dtJoin;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        int IComparable.CompareTo(object obj)
        {
            Player temp = obj as Player;
            if (this.Runs > temp.Runs)
                return 1;
            if (this.Runs < temp.Runs)
                return -1;
            else
                return 0;
        }
    }
}
