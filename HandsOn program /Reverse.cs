using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Reverse each word of the sentence (string)

example: "My name is vasu"      output->"yM eman si usav" */
namespace c_training
{
    public class Reverse
    {
        static string ReverseWords(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArr = words[i].ToCharArray();
                Array.Reverse(wordArr);
                words[i] = new string(wordArr);
            }
            return string.Join(" ", words);
        }

        static void Main()
        {
            Console.WriteLine(ReverseWords("My name is LA")); 
        }
    }
}
