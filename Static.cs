using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A static class cannot be instantiated and can only contain static methods and properties. It is useful for utility/helper methods.

namespace c_training
{
    public class @static
    {
        public static void inherited()
        {
            Console.WriteLine("Static method cannot be inherited");
        }
        public static void contain()
        {
            Console.WriteLine("it only contain methods and property");
        }
    }
   class Program
    {
        static void Main()
        {
            // Calling static methods directly without creating an object
            @static.inherited();
            @static.contain();
        }
    }
}
