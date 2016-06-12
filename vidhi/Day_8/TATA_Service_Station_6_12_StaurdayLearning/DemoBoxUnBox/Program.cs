using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;


namespace DemoBoxUnBox
{

    public class Player
    {
        string name;
        float runs;
        public string Name { get { return name; } set { name = value; } }
        public float Runs { get { return runs; } set { runs = value; } }
        public Player() { }
        public Player(string nm, float r)
        {
            name = nm;
            runs = r;
        }

        public override string ToString()
        {
            return "Player " + Name+" " + Runs;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int sachinScore = 50000;
            int rahulScore = 35000;
            int kapilScore = 5000;
            int souravScore = 40000;
            object o =(object) sachinScore;
            int result = (int)o;
 
            List<int> indainPlayersScore = new List<int>();
            indainPlayersScore.Add(sachinScore);
            indainPlayersScore.Add(rahulScore);
            indainPlayersScore.Add(kapilScore);
            indainPlayersScore.Add(souravScore);

            foreach (int i in indainPlayersScore)
            {
                Console.WriteLine(i);

            }

            Player sachin = new Player("Sachin Tendulkar", 50000);
            Player rahul = new Player("Rahul Dravid", 50000);
            Player kapil = new Player("Kapil Dev", 50000);
            Player sourav = new Player("Sourav Ganguly", 50000);
            List<Player> players = new List<Player>();

          //  ArrayList players = new ArrayList();
            players.Add(sachin);
            players.Add(rahul);
            players.Add(kapil);
            players.Add(sourav);

            Player player1 =players[0];
            Player player2 =players[1];
            Player player3 =players[2];
            Player player4 =players[4];



            Console.ReadLine();
        }
    }
}
