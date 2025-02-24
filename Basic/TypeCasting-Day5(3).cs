using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Type casting is when you assign a value of one data type to another type.
In C#, there are two types of casting:  1) Implicit Casting, 2) Explicit Casting. */

namespace Basic
{   
    internal class TypeCasting  
    {
        public void Implicit()
        {
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double.
            // Implicit casting is done automatically when passing a smaller size type to a larger size type.
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
        }
        public void Explicit()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;  // Manual casting: double to int.
            // Explicit casting must be done manually by placing the type in parentheses in front of the value.
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
        }

        public void TypeConversion()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // Convert int to string.
            Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double.
            Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int.
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string.
        }
    }
}
