using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An abstract class is a class that cannot be instantiated. It can have abstract methods (without a body) that must be overridden in derived classes.

namespace c_training
{
    // Create Abstract class
    public abstract class Abstractclass
    {
        public string Accid { get; set; }
        public string name { get; set; }

        // Abstract method (must be implemented in derived classes)
        public abstract void Accounttypes();

        // Concrete method
        public void displayacc()
        {
            Console.WriteLine($"Accid : {Accid}");
            Console.WriteLine($"Name : {name}");
        }

        // Derived class inheriting from Abstractclass
        public class SavingsAcc : Abstractclass
        {
            // Implementing abstract method ( abstract method without a body that must be ovveriden in derived class )
            public override void Accounttypes()
            {
                Console.WriteLine("this is savings Acc ");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an object of the derived class
            SavingsAcc acc = new SavingsAcc();
            acc.AccId = "12345";  // Assigning values to properties
            acc.Name = "La"; 

            // Calling methods
            acc.DisplayAcc();
            acc.Accounttypes();
        }
    }
}

// Key Concepts :
// ✅ Abstract Class: Abstractclass cannot be instantiated directly. It provides a base class for other classes.
// ✅ Abstract Method: Accounttypes() is abstract, meaning derived classes must override it.
// ✅ Concrete Method: DisplayAcc() is already implemented, so subclasses inherit it.
// ✅ Derived Class: SavingsAcc inherits from Abstractclass and provides a specific implementation for Accounttypes().
// ✅ Polymorphism: We call Accounttypes() on the SavingsAcc object, and it runs its own implementation.
