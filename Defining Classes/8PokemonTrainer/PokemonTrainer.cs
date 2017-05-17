using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PokemonTrainer
{
    public class Trainer
    {
        public string name;
        public int numberOfBadges;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            numberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }//*/

        /*public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            numberOfBadges = 0;
            this.pokemons = pokemons;
        }//*/
       /*public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            this.name = name;
            this.numberOfBadges = 0;
            this.pokemons = pokemons;
        }//*/
        public void DropHealth()
        {
            foreach(var p in pokemons)
            {
                if(p.health > 10)
                {
                    p.health -= 10;
                }
                else if(p.health <= 10)
                {
                    p.health = 0;
                }
            }
            var deadPokemons = pokemons.Where(p => p.health == 0).ToList();
            foreach(Pokemon p in deadPokemons)
            {
                if(pokemons.Any(pok => pok == p))
                {
                    pokemons.Remove(p);
                }
            }
        }
    }

    public class Pokemon
    {
        public string name;
        public string element;
        public int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }
    public class PokemonTrainer
    {
        
        public static List<Trainer> trainers = new List<Trainer>();
        
        public static void Main()
        {
            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] trainerTeam = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!trainers.Any(t => t.name == trainerTeam[0]))
                {
                    trainers.Add(new Trainer(trainerTeam[0]));
                }

                var tr = trainers.First(t => t.name == trainerTeam[0]);
                tr.pokemons.Add(new Pokemon(trainerTeam[1], trainerTeam[2], int.Parse(trainerTeam[3])));
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
           
            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if(trainer.pokemons.Any(t => t.element == command))
                    {
                        trainer.numberOfBadges++;
                    }
                    else
                    {
                        trainer.DropHealth();
                    }                   
                }
                command = Console.ReadLine();
                foreach (var trainer in trainers)
                {
                    Console.WriteLine($"{trainer.name} {trainer.numberOfBadges} {trainer.pokemons.Count}");
                }
            }
        }
    }
}
