using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Predefined Generic Delegates in C#
C# provides predefined generic delegates that are commonly used for various tasks. These delegates are part of the System namespace and help in working with methods that have a specific signature, especially when using generics.

The predefined generic delegates are:

Func<T, TResult>
Action<T>
Predicate<T>
These delegates are widely used in LINQ queries, event handling, and other scenarios that involve passing methods as arguments.

1. Func<T, TResult> Delegate
Purpose: Represents a method that takes parameters of types T and returns a result of type TResult.
Signature: Func<T, TResult> can take up to 16 parameters and returns a result of type TResult. */
namespace c_training
{
    class Predifined
    {
        static void Main9()
        {
            Func<int, float, double, double> obj1 = (a, b, c) =>
            {
                return a + b + c;
            };
            double result = obj1.Invoke(9027, 27f, 90);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (a, b, c) =>
            {
                Console.WriteLine(a + b + c);
            };
            obj2.Invoke(110, 34f, 22);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
        }
    }
}
