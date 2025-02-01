// add the original 3 Star Wars film names to the stack.

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
    }
}
