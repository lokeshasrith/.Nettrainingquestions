using System;

namespace AnimalExample
{
    // Abstract class Animal
    public abstract class Animal
    {
        protected string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat(); // Abstract method
    }
  
    public class Dog : Animal // Derived class
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Dog myDog = new Dog();
            myDog.SetName(dogName);

            Console.WriteLine($"The dog's name is: {myDog.GetName()}");
            myDog.Eat();
        }
    }
}
