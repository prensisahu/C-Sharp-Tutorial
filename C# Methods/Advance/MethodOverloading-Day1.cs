using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    internal class MethodOverloading
    {
        // Method with one parameter
        static void Display(int num)
        {
            Console.WriteLine("Integer value: " + num);
        }

        // Method with two parameters
        static void Display(int num1, int num2)
        {
            Console.WriteLine("Sum: " + (num1 + num2));
        }

        // Method with a different type of parameter
        static void Display(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        static void Main()
        {
            Display(10);             // Calls the method with one integer parameter
            Display(10, 20);         // Calls the method with two integer parameters
            Display("Hello, C#!");   // Calls the method with a string parameter
        }
    }

}
