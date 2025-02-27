using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Strings
    {
        public void StringsExample()
        {
            // Example 1
            string name = "Hello";
            Console.WriteLine(name);

            // Example 2
            string firstName = "Hello ";
            string learn = "I am reading c sharp!";  
            Console.WriteLine(firstName);
            Console.WriteLine(learn);

            // Example 3
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";  // length of the string is 26
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"
        }
        public void ConcatenationString()
        {
            // Example 1
            string firstName = "Prensi ";
            string lastName = "Sahu";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            // Example 2
            string fname = "Dhiraj ";
            string lname = "kaushik";
            string name = string.Concat(fname, lname);
            Console.WriteLine(name);

            // Example 3
            string number1 = "10";
            string number2 = "30";
            string sum = number1 + number2;
            Console.WriteLine(sum);
        }

        public void InterpolationString()
        { 
            string firstName = "Prensi";
            string lastName = "Sahu";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
        
        public void AccessString()
        {
            // Example 1
            string txt = "Hello World";
            Console.WriteLine(txt[0]);  // Outputs "H"
            Console.WriteLine(txt[1]);  // Outputs "e"
            Console.WriteLine(txt[6]);  // Outputs "W"

            // Example 2
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));   // Outputs 1 because the position starts from 0
        }

        public void SpecialCharters()
        {
            // Example 1
            string txt = "I like a \"c#\" programming language.";
            Console.WriteLine(txt);

            // Example 2
            string txt2 = "It\'s coding";   // output it's coding
            Console.WriteLine(txt2);
        }
    }
}
