using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueStudentNames
{
    class Student
    {
        string name;
        public static HashSet<string> uniqueStudents = new HashSet<string>();

        public Student(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                Student student = new Student(command);
                Student.uniqueStudents.Add(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(Student.uniqueStudents.Count());
            
        }
    }
}
