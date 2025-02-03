using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
5. Get all unique characters in a string

Example:
you can see the output as"gole". This means after removing duplicate characters from the word "google," we get the "gole" which are unique chars.  */

namespace c_training
{
    public class UniqueCharacters
    {
        static string GetUniqueChars(string str)
        {
            var uniqueChars = str.Distinct().ToArray();
            return new string(uniqueChars);
        }

        static void Main()
        {
            // Test case
            Console.WriteLine(GetUniqueChars("google"));  // Output: "gole"
        }
    }
}
