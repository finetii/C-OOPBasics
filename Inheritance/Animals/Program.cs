using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {            
            string command = Console.ReadLine();
            while (command != "Beast!")
            {
                try
                {
                    string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    string name = input[0];
                    int age = 0;
                    if(!int.TryParse(input[1], out age))
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }
                    string gender = input[2];
                    switch (command.ToLower())
                    {
                        case "cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(command);
                            Console.WriteLine(cat);
                            break;
                        case "dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(command);
                            Console.WriteLine(dog);
                            break;
                        case "frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(command);
                            Console.WriteLine(frog);
                            break;
                        case "kitten":
                            Kitten kitten = new Kitten(name, age);
                            Console.WriteLine(command);
                            Console.WriteLine(kitten);
                            break;
                        case "tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            Console.WriteLine(command);
                            Console.WriteLine(tomcat);
                            break;
                        default:
                            //Animal animal = new Animal(name, age, gender);
                            //Console.WriteLine(command);
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                command = Console.ReadLine();
            }

        }
    }
}
