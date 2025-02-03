using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Maximum consecutive one’s (or zeros) in a binary array
Given a binary array, find the count of a maximum number of consecutive 1s present in the array.

Examples : 

Input: arr[] = {1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1}
Output: 4
Explanation: The maximum number of consecutive 1’s in the array is 4 from index 8-11.


Input: arr[] = {0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1}
Output: 1
Explanation: The maximum number of consecutive 0’s in the array is 1 from index 0-1.
*/
namespace c_training
{
    public class BinaryArray
    {
        static int MaxConsecutiveOnes(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (var num in arr)
            {
                if (num == 1)
                {
                    currentCount++; 
                    maxCount = Math.Max(maxCount, currentCount); 
                }
                else
                {
                    currentCount = 0; 
                }
            }

            return maxCount;
        }

        static void Main()
        {
            Console.WriteLine(MaxConsecutiveOnes(new int[] { 1, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 1 }));  
            Console.WriteLine(MaxConsecutiveOnes(new int[] { 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 })); 
        }
    }
}
