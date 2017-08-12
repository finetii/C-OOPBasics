using System;


namespace SingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Eat());
            Console.WriteLine(dog.Bark());

            Puppy puppy = new Puppy();
            Console.WriteLine(puppy.Eat());
            Console.WriteLine(puppy.Bark());
            Console.WriteLine(puppy.Weep());

            Cat cat = new Cat();
            Console.WriteLine(cat.Eat());
            Console.WriteLine(cat.Meow());
        }
    }
}
