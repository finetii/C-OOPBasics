using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FamilyTree
{
    public class Person
    {
        public string name;
        public List<Person> parents = new List<Person>();
        public List<Person> children = new List<Person>();
        public DateTime birthday;

        public Person(string n)
        {
            name = n;
        }

        public Person (DateTime bDay)
        {
            birthday = bDay;
        }
        
        public Person(string n, DateTime bDay)
        {
            name = n;
            birthday = bDay;
        }
    }
    class FamilyTree
    {
        static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            //Person personToOutput = null;
            DateTime birthday;
            if(DateTime.TryParse(command, out birthday))
            {
                persons.Add(new Person(birthday));
            }
            else
            {
                persons.Add(new Person(command));
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                string[] personInfo = null;
                if (command.Contains("-"))
                {
                    personInfo = command.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                    AddPerson(personInfo);
                }
                else
                {
                    personInfo = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(persons.Any(p => p.name == personInfo[0]+ " " + personInfo[1]))
                    {
                        Person pp = persons.Where(p => p.name == personInfo[0] + " " + personInfo[1]).FirstOrDefault();
                        pp.birthday = DateTime.Parse(personInfo[2]);
                    }
                    else
                    {
                        persons.Add(new Person(personInfo[0] + " " + personInfo[1], DateTime.Parse(personInfo[2])));
                    }
                }
                command = Console.ReadLine();
            }
        }
        static void AddPerson(string[] str)
        {
            Person parent;
            Person child;
            if(!isName(str[0]))
            {
                if (!Exists(str[0]))
                    parent = new Person(DateTime.Parse(str[0]));
                else
                {
                    DateTime bday;
                    Person temp = DateTime.TryParse(str[1], out bday) ? ReturnChild(bday) : ReturnChild(str[1]);
                    persons.Where(p => p.birthday == DateTime.Parse(str[0])).FirstOrDefault()
                        .children.Add(temp);
                    if (!persons.Any(p => p == temp))
                    {
                        persons.Add(temp);
                        temp.parents.Add(persons.Where(p => p.birthday == DateTime.Parse(str[0])).FirstOrDefault());
                    }
                    else
                    {
                        persons.Where(p => p == temp).FirstOrDefault().parents.Add(persons.Where(p => p.birthday == DateTime.Parse(str[0])).FirstOrDefault());
                    }
                }
            }
            else
            {
                if (!Exists(str[0]))
                {
                    persons.Add(new Person(str[0]));
                    DateTime bday;
                    Person temp = DateTime.TryParse(str[1], out bday) ? ReturnChild(bday) : ReturnChild(str[1]);
                    persons.Where(p => p.name == str[0]).FirstOrDefault()
                        .children.Add(temp);
                    if (!persons.Any(p => p == temp))
                    {
                        persons.Add(temp);
                        temp.parents.Add(persons.Where(p => p.name == str[0]).FirstOrDefault());
                    }
                    else
                    {
                        persons.Where(p => p == temp).FirstOrDefault().parents
                            .Add(persons.Where(p => p.name == str[0]).FirstOrDefault());
                    }
                }
                else
                {
                    DateTime bday;
                    Person temp = DateTime.TryParse(str[1], out bday) ? ReturnChild(bday) : ReturnChild(str[1]);
                    persons.Where(p => p.name == str[0]).FirstOrDefault()
                        .children.Add(temp);
                    if (!persons.Any(p => p == temp))
                    {
                        persons.Add(temp);
                        temp.parents.Add(persons.Where(p => p.name == str[0]).FirstOrDefault());
                    }
                    else
                    {
                        persons.Where(p => p == temp).FirstOrDefault().parents.Add(persons.Where(p => p.name == str[0]).FirstOrDefault());
                    }
                }
            }
            
        }
        static Person ReturnChild(string name)
        {
            if(persons.Any(p => p.name == name))
            {
                return persons.Where(p => p.name == name).FirstOrDefault();
            }
            else
            {
                return new Person(name);
            }
        }
        static Person ReturnChild(DateTime bday)
        {
            if (persons.Any(p => p.birthday == bday))
            {
                return persons.Where(p => p.birthday == bday).FirstOrDefault();
            }
            else
            {
                return new Person(bday);
            }
        }
        static bool isName(string str)
        {
            DateTime bDay;
            if (DateTime.TryParse(str, out bDay))
            {
                return false;
            }
            else
                return true;
        }
        static bool Exists(DateTime bday)
        {
            if (persons.Any(p => p.birthday == bday))
                return true;
            return false;
        }
        static bool Exists(string name)
        {
            if (persons.Any(p => p.name == name))
                return true;
            return false;
        }
    }
}
