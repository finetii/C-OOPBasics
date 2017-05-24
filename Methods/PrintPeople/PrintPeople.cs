using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPeople
{
    public class Person
    {
        public string name;
        public int age;
        public string occupation;

        public Person (string name, int age, string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public override string ToString()
        {
            return $"{name} - age: {age}, occupation: {occupation}";
        }
    }
    class PrintPeople
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                persons.Add(new Person(input[0], int.Parse(input[1]), input[2]));                
                command = Console.ReadLine();
            }

            
            foreach (var person in persons.OrderBy(p=>p.age))
            {
                Console.WriteLine(person.ToString());
            }
           
        }
    }
}
