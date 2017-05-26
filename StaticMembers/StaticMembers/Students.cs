using System;

namespace StaticMembers
{
    class Student
    {
        string name;
        public static int numberOfInstances = 0;
        public Student(string name)
        {
            this.name = name;
            numberOfInstances++;
        }
    }
    class Students
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                Student student = new Student(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(Student.numberOfInstances);
        }
    }
}
