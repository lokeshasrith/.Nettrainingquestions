using System;
// A virtual method is a method in a base class that can be overridden in a derived class.
namespace c_training
{
    public class Virtualacc
    {
        // Virtual method (can be overridden in derived classes)
        public virtual void Account()
        {
            Console.WriteLine("this is general acc");
        }
    }

    // Derived class that overrides the virtual method
    public class Acc : Virtualacc
    {
        public override void Account()
        {
            Console.WriteLine("this is savings acc");
        }
    }

    class Program
    {
        static void Main()
        {
            // Base class reference calling base class method
            Virtualacc VA = new Virtualacc();
            VA.Account();  // Output: this is general acc

            // Base class reference pointing to derived class object (Runtime Polymorphism)
            Virtualacc acc = new Acc();
            acc.Account();  // Output: this is savings acc
        }
    }
}
