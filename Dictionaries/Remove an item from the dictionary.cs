// remove the item with the key 'Han' from the dictionary.
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

        characters.Remove("Han");
    }
}
