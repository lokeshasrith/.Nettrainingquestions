using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LanguageExt.UnitsOfMeasure;

namespace c_training
{
    public class MethodOverloading
    {
        public string AccId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }

        // Method Overloading
        public void DisplayAcc(string accId)
        {
            Console.WriteLine($"Account ID: {accId}");
        }

        public void DisplayAcc(string accId, string name)
        {
            Console.WriteLine($"Account ID: {accId}, Name: {name}");
        }

        public void DisplayAcc(string accId, string name, string password)
        {
            Console.WriteLine($"Account ID: {accId}, Name: {name}, Password: {password}");
        }

        public void DisplayAcc(string accId, string name, string password, string accType)
        {
            Console.WriteLine($"Account ID: {accId}, Name: {name}, Password: {password}, Account Type: {accType}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of MethodOverloading
            MethodOverloading MO = new MethodOverloading();

            // Call overloaded methods with different arguments
            MO.DisplayAcc("027");
            MO.DisplayAcc("027", "LA");
            MO.DisplayAcc("027", "LA", "La@");
            MO.DisplayAcc("027", "LA", "La@", "Savings");

            // Wait for user input to keep console open
            Console.ReadLine();
        }
    }
}
