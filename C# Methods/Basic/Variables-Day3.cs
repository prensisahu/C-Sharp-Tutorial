using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Variables  // `public class Variables` is used to define a class that is accessible from any assembly. This means the class can be accessed from anywhere.
    {
        public void VariablesExample()
        {
            int myNum = 3;  // Integer (whole number)
            Console.WriteLine(myNum);

            int Num = 15;
            Num = 20;   // Change the value of Num to 20:
            Console.WriteLine(Num);

            long mylong = 15000000000; // A long integer
            Console.WriteLine(mylong);

            float myFloat = 5.75F;  // A floating-point number
            Console.WriteLine(myFloat);

            double myDoubleNum = 3.33;  // Double-precision floating-point number
            Console.WriteLine(myDoubleNum);

            char myLetter = 'M';     // Character
            Console.WriteLine(myLetter);

            bool myBool = true;   // Boolean
            Console.WriteLine(myBool);

            string name = "Hello";    // String
            Console.WriteLine(name);
        }
    }
}
