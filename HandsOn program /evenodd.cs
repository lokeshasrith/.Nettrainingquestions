using System;

namespace c_training
{
    public class evenodd
    {
        public void find()
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];
            Console.WriteLine($"Input {num} elements in the array:");

            for (int i = 0; i < num; i++)
            {
                Console.Write($"element - {i} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe even numbers are:"); // for even numbers
            foreach (var item in numbers)
            {
                if (item % 2 == 0)   // remainder is 0 which == zero  
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine("\nThe Odd elements are:");  // for odd numbers
            foreach (var item in numbers)
            {
                if (item % 2 != 0) // remainder is not 0 then not equal to o
                {
                    Console.Write(item + " ");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            evenodd myEvenOdd = new evenodd();
            myEvenOdd.find();
            Console.ReadLine();
        }
    }
}
