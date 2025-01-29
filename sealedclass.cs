using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    sealed class sealedclass
    {
        public void seal()
        {
            Console.WriteLine("Sealclass cannot be inherited, it used furthure modification of a class");
        }

        //Note:

        //If you try to inherit from a sealed class, you will get a compilation error.

        // Error! Cannot inherit from sealed class
        // class PersonalLoan : LoanAccount { }
    }
    class Program
    {
        static void Main()
        {
            sealedclass SC = new sealedclass();
            SC.seal();
        }
    }
}

// Output:
// Sealclass cannot be inherited, it used furthure modification of a class
