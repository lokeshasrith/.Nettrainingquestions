// loop through the stack using a do-while loop, and remove each item from it. Write each item to the Console using WriteLine
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<string> films = new Stack<string>();

        films.Push("A New Hope");
        films.Push("The Empire Strikes Back");
        films.Push("Return Of The Jedi");

        do
        {
            string film = films.Pop(); 
            Console.WriteLine(film);    
        } while (films.Count > 0); 
    }
}
