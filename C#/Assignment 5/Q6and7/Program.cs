using System;
using System.Collections;
namespace players
{
    public class Player
    {
        public String Name { get; set; }
        public int RunsScored { get; set; }

        public Player() { }

        public Player(string name, int runsScored)
        {
            Name = name;
            RunsScored = runsScored;
        }
    }

    public class Team : IEnumerable
    {
        
        public Player[] player;

        public Team() { }
        public Team(int numberOfPlayers)
        {
            
            player = new Player[NumberOfPlayers];

        }

        public Player AddPlayer(string name, int runsScored)
        {
            Player player1 = new Player(name, runsScored);
            return player1;



        }
        public IEnumerator GetEnumerator()
        {

            return player.GetEnumerator();
        }
    }

    public class program
    {
        public static void Main()
        {
            Console.WriteLine("Enter no of players in the team");
            int n = Convert.ToInt32(Console.ReadLine());
            string name;
            int runsscored;
            Team India = new Team(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter name of Player {i + 1}");
                name = Console.ReadLine();
                Console.WriteLine($"Enter runs Scored by Player {i + 1}");
                runsscored = Convert.ToInt32(Console.ReadLine());
                India.player[i] = India.AddPlayer(name, runsscored);

            }
            //Q6
            foreach (Player player in India.player)
            {
                Console.WriteLine($"\n Player name:{player.Name} \n Runs Scored by player:{player.RunsScored}");
            }
            //Q7
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n Player name:{India.player[i].Name} \n Runs Scored by player:{India.player[i].RunsScored}");
            }

        }

    }
}

