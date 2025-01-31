using System;

namespace c_training
{
    public class FinallyBlock
    {
        static void main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                if (b == 1)
                {
                    return;  
                }

                int c = a / b;
                Console.WriteLine("The output: " + c);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally // these block executes it there is a error or npt there an error
            {
                Console.WriteLine("Finally block executed");
            }

            Console.WriteLine("End of the Program");
        }
    }
}
