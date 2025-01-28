using System;

namespace c_training
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }

        public virtual void Loantypes()
        {
            Console.WriteLine("General loans");
        }

        public virtual void accounttypes()
        {
            string[] types = { "savings", "current", "corporate" };
            foreach (string type in types)
            {
                Console.WriteLine(type);
            }
        }

        // Derived class SBi
        public class SBi : Account
        {
            public override void Loantypes()
            {
                Console.WriteLine("Housing loans");
            }

            public override void accounttypes()
            {
                string[] types = { "savings", "current" };
                foreach (string type in types)
                {
                    Console.WriteLine(type);
                }
            }
        }

        // Derived class HDFC
        public class HDFC : Account
        {
            public override void Loantypes()
            {
                Console.WriteLine("Car loans");
            }

            public override void accounttypes()
            {
                string[] types = { "savings", "current", "personal" };
                foreach (string type in types)
                {
                    Console.WriteLine(type);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of derived classes
            Account.SBi sbi = new Account.SBi();
            Account.HDFC hdfc = new Account.HDFC();

            // Display SBI Account details
            Console.WriteLine("SBI Account:");
            sbi.Loantypes();
            sbi.accounttypes();

            // Display HDFC Account details
            Console.WriteLine("\nHDFC Account:");
            hdfc.Loantypes();
            hdfc.accounttypes();

            Console.ReadLine();  // Wait for user input before closing the console
        }
    }
}
