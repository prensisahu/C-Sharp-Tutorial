using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic // namespace Basic is used to define a scope that contains classes, functions, or other types in C#. It helps organize code into logical groups.
{
    internal class Syntax   // internal class Syntax is used to define a class that is accessible only within the same assembly, not outside of it.
    {
        public void SyntaxExample() // `public void SyntaxExample()` defines a method named `SyntaxExample` that is publicly accessible (can be called from anywhere) and does not return any value (because of `void`).
        {
            Console.WriteLine("Hello World!");  // Console.Write is a method in C# used to print something to the console screen.
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);   // You can also output numbers, and perform mathematical calculations.
        }
    }
}
