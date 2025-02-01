// create a for loop after the array declaration, and loop through the values, writing each to the console.

using System;

using System;

public class Loopthroughthearray
{
    public static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for(int i = 0;i < numbers.Length;i++)
		{
			Console.WriteLine(numbers[i]);
		}
    }
}
