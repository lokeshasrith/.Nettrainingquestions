using System;

namespace c_training
{
    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }
    }

    public class Firstname
    {
        private Person[] People = new Person[3];

        public void GetNames()
        {
            for (int i = 0; i < People.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                People[i] = new Person { Name = Console.ReadLine() };
            }
        }

        public void PrintPeople()
        {
            foreach (Person person in People)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Firstname firstname = new Firstname();
            firstname.GetNames();
            firstname.PrintPeople();
        }
    }
}
