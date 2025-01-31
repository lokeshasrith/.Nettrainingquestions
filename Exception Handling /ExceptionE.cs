using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    public class ExceptionE
    {
        public static void Main(string[] args)  
        {
            try
            {
                Console.Write("Enter first number: "); 
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("The output : " + c);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Input must be numerical"); 
            }
            catch (Exception ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            Console.WriteLine("End of the program"); 
            Console.ReadKey();
        }
    }
}
