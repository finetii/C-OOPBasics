using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewFamilyTree
{
    public class NewFamilyTree
    {
        public class Person
        {
            public string name;
            public string birthday;
            public List<Person> parents = new List<Person>();
            public List<Person> children = new List<Person>();

            public Person (string name)
            {
                this.name = name;
            }

            public Person(string name, string birthday) : this(name)
            {
                this.birthday = birthday;
            }

            public override string ToString()
            {
                string output = $"{name} {birthday}";
                output += "\nParents:\n";
                foreach (var parent in parents)
                {
                    output += $"{parent.name} {parent.birthday}\n";
                }
                output += "Children:\n";
                foreach (var child in children)
                {
                    output += $"{child.name} {child.birthday}\n";
                }
                return output;
            }
        }
        static void Main()
        {
            List<Person> persons = new List<Person>();
            List<string> notFullPersons = new List<string>();

            string personToOutput = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "End")
            {
                if (!command.Contains("-"))
                {
                    string[] personInfo = command.Split(new char[] { ' ' }, StringSplitOptions.None);
                    string name = personInfo[0] + " " + personInfo[1];
                    string birthday = personInfo[2];
                    persons.Add(new Person(name, birthday));
                }
                else
                    notFullPersons.Add(command);
                command = Console.ReadLine();
            }

            foreach (var person in notFullPersons)
            {
                Person parent;
                Person child;

                string[] personInfo = person.Split(new string[] { " - " }, StringSplitOptions.None);

                if (personInfo[0].Contains("/"))
                {
                    if (personInfo[1].Contains("/"))
                    {
                        parent = persons.FirstOrDefault(p => p.birthday == personInfo[0]);
                        child = persons.FirstOrDefault(c => c.birthday == personInfo[1]);
                    }
                    else
                    {
                        parent = persons.FirstOrDefault(p => p.birthday == personInfo[0]);
                        child = persons.FirstOrDefault(c => c.name == personInfo[1]);
                    }            
                }
                else
                {
                    if (personInfo[1].Contains("/"))
                    {
                        parent = persons.FirstOrDefault(p => p.name == personInfo[0]);
                        child = persons.FirstOrDefault(c => c.birthday == personInfo[1]);
                    }
                    else
                    {
                        parent = persons.FirstOrDefault(p => p.name == personInfo[0]);
                        child = persons.FirstOrDefault(c => c.name == personInfo[1]);
                    }
                }
                if(!parent.children.Contains(child))
                {
                    parent.children.Add(child);
                }
                if(!child.parents.Contains(parent))
                {
                    child.parents.Add(parent);
                }
            }
            if(personToOutput.Contains("/"))
            {
                Console.WriteLine(persons.Where(p=>p.birthday == personToOutput).FirstOrDefault().ToString());
            }
            else
                Console.WriteLine(persons.Where(p=>p.name == personToOutput).FirstOrDefault().ToString());
        }
        
    }
}
