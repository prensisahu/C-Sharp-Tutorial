using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    internal class MethodParameters
    {
        static void GreetUser(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old.");
        }

        static void Main()
        {
            // Method call with arguments
            GreetUser("Prensi", 22);
            GreetUser("Sanju", 21);
        }
    }
}
