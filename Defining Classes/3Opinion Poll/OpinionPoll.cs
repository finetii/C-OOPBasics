using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Opinion_Poll
{
    class Person
    {
        private string name;
        private int age;

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
    public class OpinionPoll
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(personInfo[0], int.Parse(personInfo[1]));
                people.Add(person);
            }

            var result = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (var p in result)
            {
                Console.WriteLine("{0} - {1}", p.Name,p.Age);
            }
        }
    }
}
