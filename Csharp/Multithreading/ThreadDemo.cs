using System;
using System.Threading;
// A thread is the smallest unit of execution within a process. It represents a single sequence of instructions that the CPU can execute independently.
namespace c_training
{
    public class ThreadDemo
    {
        public void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 1 : " + i);
            }
        }

        public void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 2 : " + i);
            }
        }
        public void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 1 : " + i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();
            Console.WriteLine("Current executing Thread");
            Thread t1 = new Thread(new ThreadStart(demo.Test1));
            Thread t2 = new Thread(new ThreadStart(demo.Test2));
            Thread t3 = new Thread(new ThreadStart(demo.Test3));
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Thread is executed");
        }
    }
}

// Thread Sleep
public void Test2()
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine("Test 1 : " + i);
        if (i == 50)
        {
            Console.WriteLine("test 2 is sleep");
            Thread.Sleep(5000);
            Console.WriteLine("test 2 is wake");
        }
    }
}
