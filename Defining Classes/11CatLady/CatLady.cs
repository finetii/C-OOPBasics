using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CatLady
{
    public class Cat
    {
        public string name;
        protected Cat () { }
    }

    public class Siamese : Cat
    {
        public uint earSize;

        public Siamese(string name, uint earSize)
        {
            this.name = name;
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"Siamese {(name)} {earSize}";
        }
    }
    public class Cymric : Cat
    {
        public float furLength;

        public Cymric(string name, float furLength)
        {
            this.name = name;
            this.furLength = furLength;
        }

        public override string ToString()
        {
            return $"Cymric {name} {furLength:f2}";
        }
    }
    public class StreetExtraordinaire : Cat
    {
        public uint decibelsOfMeows;

        public StreetExtraordinaire(string name, uint decibelsOfMeows)
        {
            this.name = name;
            this.decibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {name} {decibelsOfMeows}";
        }
    }
    public class CatLady
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] catInfo = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 

                switch(catInfo[0])
                {
                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire(catInfo[1], uint.Parse(catInfo[2])));
                        break;
                    case "Siamese":
                        cats.Add(new Siamese(catInfo[1], uint.Parse(catInfo[2])));
                        break;
                    case "Cymric":
                        cats.Add(new Cymric(catInfo[1], float.Parse(catInfo[2])));
                        break;
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            Console.WriteLine(cats.Where(c=>c.name == command).FirstOrDefault().ToString());
        }
    }
}
