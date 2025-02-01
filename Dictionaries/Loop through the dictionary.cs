// create a foreach loop after the dictionary declaration and loop through the tiems, writing the Value to the console using Console.WriteLine. 
// Your loop variable should be declared as 'var'.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, bool> characters = new Dictionary<string, bool>()
        {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", false }
        };

        foreach (var character in characters)
        {
            Console.WriteLine(character.Value);
        }
    }
}
