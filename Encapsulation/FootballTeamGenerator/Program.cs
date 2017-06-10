using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <param name="name"></param>
        /// <param name="endurance"></param>
        /// <param name="sprint"></param>
        /// <param name="dribble"></param>
        /// <param name="passing"></param>
        /// <param name="shooting"></param>
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (string.IsNullOrEmpty(name.Trim()))
                throw new Exception("A name should not be empty.");
            this.Name = name;

            if (endurance < 0 || endurance > 100)
                throw new Exception("Endurance should be between 0 and 100.");
            this.endurance = endurance;

            if (sprint < 0 || sprint > 100)
                throw new Exception("Sprint should be between 0 and 100.");
            this.sprint = sprint;

            if (dribble < 0 || dribble > 100)
                throw new Exception("Dribble should be between 0 and 100.");
            this.dribble = dribble;

            if (passing < 0 || passing > 100)
                throw new Exception("Passing should be between 0 and 100.");
            this.passing = passing;

            if (shooting < 0 || shooting > 100)
                throw new Exception("Shooting should be between 0 and 100.");
            this.shooting = shooting;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                else
                    this.name = value;
            }
        }

        public int Skill()
        {
            return (int)Math.Round((this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5.0);

        } 
    }

    class Team
    {
        private string name;
        private List<Player> players;        

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty");
                }
                else
                    this.name = value;
            }
        }
        
        public void AddPlayers(Player player)
        {
            Player oldPlayer = this.players.FirstOrDefault(p => p.Name == player.Name);
            if (oldPlayer != null)
                this.players.Remove(oldPlayer);
            this.players.Add(player);
        }

        /// <summary>
        /// Removes player
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <param name="playerName"></param>
        public void RemovePlayer(string playerName)
        {
            Player oldPlayer = this.players.FirstOrDefault(p => p.Name == playerName);
            if (oldPlayer == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(oldPlayer);
        }

        public int CalculateRating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            else
                return (this.players.Select(p => p.Skill()).Sum() / this.players.Count());
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Team> teams = new List<Team>();
                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] teamInput = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);


                    switch (teamInput[0])
                    {
                        case "Team":
                            if (!teams.Any(t => t.Name == teamInput[1]))
                                teams.Add(new Team(teamInput[1]));
                            break;
                        case "Add":
                            try
                            {
                                Team team = teams.Where(t => t.Name == teamInput[1]).FirstOrDefault();
                                if (team == null)
                                    throw new Exception($"Team {teamInput[1]} does not exist.");

                                team.AddPlayers(new Player(teamInput[2],
                                                            int.Parse(teamInput[3]),
                                                            int.Parse(teamInput[4]),
                                                            int.Parse(teamInput[5]),
                                                            int.Parse(teamInput[6]),
                                                            int.Parse(teamInput[7]))
                                                            );


                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            } break;
                        case "Remove":
                            {
                                try
                                {
                                    Team team = teams.FirstOrDefault(t => t.Name == teamInput[1]);
                                    if (team == null)
                                        throw new Exception($"Team {teamInput[1]} does not exist.");
                                    team.RemovePlayer(teamInput[2]);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }break;
                            }
                        case "Rating":
                            {
                                try
                                {
                                    Team team = teams.FirstOrDefault(t => t.Name == teamInput[1]);
                                    if (team == null)
                                        throw new Exception($"Team {teamInput[1]} does not exist.");

                                    Console.WriteLine($"{team.Name} - {team.CalculateRating()}");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }break;
                            }
                    }


                    command = Console.ReadLine();
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
