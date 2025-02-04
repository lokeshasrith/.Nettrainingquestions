using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Multithreading is a programming technique that allows a process to execute multiple threads concurrently.
// Each thread is an independent sequence of execution within the program, enabling it to perform multiple tasks simultaneously.
namespace c_training
{
    public class multithreaddemo
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 1 : " + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 2 : " + i);
            }
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 3 : " + i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Current executing Thread");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("All threads have been executed.");
        }
    }
}
