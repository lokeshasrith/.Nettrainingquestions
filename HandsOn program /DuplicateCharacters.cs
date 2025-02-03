using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Find duplicate characters in a string

Example:
Here, you can see we have passed "google" as a string, and we got a result as "og". It means these two characters (og)are duplicates in the word "google".
*/

namespace c_training
{
    public class DuplicateCharacters
    {
        static string FindDuplicates(string str)
        {
            var duplicates = str.GroupBy(c => c)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key)
                                .ToArray();
            return new string(duplicates);
        }

        static void Main()
        {
            // Test case
            Console.WriteLine(FindDuplicates("google"));  // Output: "og"
        }
    }
}
