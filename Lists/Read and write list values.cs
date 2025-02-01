// add the item Chewbacca to the list. On the next line, write the first item in the list to the Console.
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> characters = new List<string>();
        characters.Add("Chewbacca");
        Console.WriteLine(characters[0]);
    }
}
