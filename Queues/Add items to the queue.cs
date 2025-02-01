// Add items to the queue

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
    }
}

// for print the added values
foreach (int prime in primes)
{
   Console.WriteLine(prime);
}
