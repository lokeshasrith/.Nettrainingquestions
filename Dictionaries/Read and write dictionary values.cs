// Please add a new value, the key of which is your name, and the value of which is your age. Do this using the Add method.Next, add another value to the dictionary using the index notation. 
//This time, use a different name and a different age.Lastly, read the first item you added to the dictionary, and write it to the console using Console.WriteLine`.
using System;
using System.Collections.Generic;
using System.Linq;  

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> people = new Dictionary<string, int>();

        people.Add("la", 2);
        people["Alice"] = 30;

        var firstItem = people.FirstOrDefault();
        Console.WriteLine(string.Format("Name: {0}, Age: {1}", firstItem.Key, firstItem.Value));
    }
}
