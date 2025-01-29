using System;
// Implicit (Default) Constructor:

// If you don’t define a constructor, the C# compiler adds a hidden parameterless constructor automatically.

// This default constructor initializes variables to their default values:

// Numbers: 0

// Booleans: false

// Objects/strings: null
using System;

class Test
{
    public int i;   // Default value = 0
    public bool b;  // Default value = false
    public string s; // Default value = null
}

class Program
{
    static void Main()
    {
        Test obj = new Test();  // Calls the implicit constructor
        Console.WriteLine($"i = {obj.i}");  // Output: i = 0
        Console.WriteLine($"b = {obj.b}");  // Output: b = False

        if (obj.s == null)
        {
            Console.WriteLine("s = null");  // Output: s = null
        }
    }
}

