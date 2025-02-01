//  loop through the queue using a while loop, and add the next item to the total variable. After the loop, please write the total to the console using Console.WriteLine.
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<int> primes = new Queue<int>();

        primes.Enqueue(2);
        primes.Enqueue(3);
        primes.Enqueue(5);
        primes.Enqueue(7);
        primes.Enqueue(11);

        int total = 0;

        while (primes.Count > 0)
        {
            total += primes.Dequeue();
        }

        Console.WriteLine(total);
    }
}
