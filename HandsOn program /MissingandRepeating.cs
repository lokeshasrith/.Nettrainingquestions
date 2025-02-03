using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Missing and Repeating in an Array

Given an unsorted array of size n. Array elements are in the range of 1 to n. One number from set {1, 2, …n} is missing and one number occurs twice in the array. Find these two numbers.

Examples: 

Input: arr[] = {3, 1, 3}
Output: Missing = 2, Repeating = 3
Explanation: In the array, 2 is missing and 3 occurs twice 


Input: arr[] = {4, 3, 6, 2, 1, 1}
Output: Missing = 5, Repeating = 1*/

namespace c_training
{
    public class MissingandRepeating
    {
        static void FindMissingAndRepeating(int[] arr)
        {
            int n = arr.Length;
            int sum = (n * (n + 1)) / 2; 
            int squareSum = (n * (n + 1) * (2 * n + 1)) / 6; 

            int actualSum = 0, actualSquareSum = 0;
            foreach (int num in arr)
            {
                actualSum += num;
                actualSquareSum += num * num;
            }

            int sumDiff = sum - actualSum; 
            int squareSumDiff = squareSum - actualSquareSum; 
            int missing = (sumDiff + (squareSumDiff / sumDiff)) / 2;
            int repeating = missing - sumDiff;

            Console.WriteLine($"Missing = {missing}, Repeating = {repeating}");
        }

        static void Main()
        {
            FindMissingAndRepeating(new int[] { 3, 1, 3 });  
            FindMissingAndRepeating(new int[] { 4, 3, 6, 2, 1, 1 });  
        }
    }
}
