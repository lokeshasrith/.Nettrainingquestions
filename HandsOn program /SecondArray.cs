using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Second Largest Element in an Array
Given an array of positive integers arr[] of size n, the task is to find second largest distinct element in the array.

Note: If the second largest element does not exist, return -1.

Examples:

Input: arr[] = [12, 35, 1, 10, 34, 1]
Output: 34
Explanation: The largest element of the array is 35 and the second largest element is 34.


Input: arr[] = [10, 5, 10]
Output: 5
Explanation: The largest element of the array is 10 and the second largest element is 5.


Input: arr[] = [10, 10, 10]
Output: -1
Explanation: The largest element of the array is 10 there is no second largest element.
*/

namespace c_training
{
    public class SecondArray
    {
        static int SecondLargest(int[] arr)
        {
            var distinctArr = arr.Distinct().ToArray();

            if (distinctArr.Length < 2)
                return -1;

            Array.Sort(distinctArr);
            Array.Reverse(distinctArr);
            return distinctArr[1];
        }

        static void Main()
        {
            Console.WriteLine(SecondLargest(new int[] { 12, 35, 1, 10, 34, 1 }));  
            Console.WriteLine(SecondLargest(new int[] { 10, 5, 10 }));  
            Console.WriteLine(SecondLargest(new int[] { 10, 10, 10 })); 
        }
    }
}
