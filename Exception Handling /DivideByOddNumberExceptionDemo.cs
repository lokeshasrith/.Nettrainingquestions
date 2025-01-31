using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    public class dividebyoddnumberexception : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Tried to divivde by odd number";
            }
        }
    }
    public class DivideByOddNumberExceptionDemo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            if (b % 2 > 0)
            {
                throw new dividebyoddnumberexception();
            }

            int c = a / b;
            Console.WriteLine("The output: " + c);
            Console.WriteLine("End of the Program");
        }
    }
}

