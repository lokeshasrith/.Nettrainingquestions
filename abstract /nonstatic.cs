
using System;
// A non-static class is a regular class that can be instantiated (i.e., you can create objects from it). Unlike static classes, it can have instance members (non-static properties and methods).
namespace c_training
{
    class Account
    {
        // Instance properties
        public string AccId { get; set; }
        public string Name { get; set; }

        // Instance method
        public void DisplayAccount()
        {
            Console.WriteLine($"Account ID: {AccId}, Name: {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an object of the non-static class
            Account acc1 = new Account();
            acc1.AccId = "A101";
            acc1.Name = "John Doe";

            Account acc2 = new Account();
            acc2.AccId = "A102";
            acc2.Name = "Alice";

            // Calling instance methods
            acc1.DisplayAccount();
            acc2.DisplayAccount();
        }
    }
}


// Key Points:
// ✅ Can be instantiated (you can create multiple objects).
// ✅ Has instance members (non-static properties and methods).
// ✅ Each object has its own copy of instance variables (e.g., AccId and Name).
// ❌ Cannot be accessed without an object (unlike a static class).
