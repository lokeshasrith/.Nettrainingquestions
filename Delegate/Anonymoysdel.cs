using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Anonymous Delegates
An anonymous delegate is a delegate that does not have a named method but is defined inline in the code. This allows you to pass a delegate without the need to create a separate method.

You can use anonymous delegates to quickly define small methods without having to write a whole method body elsewhere.

Why Use Anonymous Delegates?
Convenience: When you want to quickly write small, one-off methods without defining a separate named method.
Readability: It keeps the code short and compact. */

namespace c_training
{
    public delegate string Getname(string name);

    class Anonymoysdel 
    {
        static void Main(string[] args) 
        {
            Getname obj = delegate (string name)
            {
                return "hello " + name; 
            };

            string str = obj.Invoke("La"); 
            Console.WriteLine(str); 
            Console.ReadKey(); 
        }
    }
}
