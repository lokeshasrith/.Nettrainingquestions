using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Delegates in C# 
A delegate is like a pointer to a function.
It allows you to store a reference to a method and call that method later.

Why Use Delegates?
To call methods dynamically at runtime.
To pass methods as parameters to other methods.
Used in event handling (like button clicks in apps). */

namespace c_training
{
    public delegate void Adddelegate(int a, int b);
    public delegate string namedelegate(string name);

    public class Prodelegatedemo
    {
        public void Addnums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string Sayname(string name)
        {
            return "Hello " + name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prodelegatedemo del = new Prodelegatedemo();

            Adddelegate ad = new Adddelegate(del.Addnums);
            namedelegate nd = new namedelegate(Prodelegatedemo.Sayname);

            ad.Invoke(90, 27); 
            Console.WriteLine(nd.Invoke("John")); 
        }
    }
} 
