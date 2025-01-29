using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Implicit (Default) Constructor:

// If you don’t define a constructor, the C# compiler adds a hidden parameterless constructor automatically.

// This default constructor initializes variables to their default values:

// Numbers: 0

// Booleans: false

// Objects/strings: null
namespace c_training
{
    public class test
    {
        public int a;
        public bool b;
        public string c;
    } // Compiler adds a hidden constructor to initialize Number=0, Flag=false, Text=null.  
  
  class Program
  {
      static void Main()
      {
          test IT = new test();
          Console.WriteLine($"a = {IT.a}");
          Console.WriteLine($"b = {IT.b}");
          if (IT.c == null)
          {
              Console.WriteLine("c = Null");
          }
    }
}
