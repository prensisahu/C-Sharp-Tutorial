using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class UserInput
    {
        public void UserinputExample()
        {
             Console.Write("Enter your name: ");  // Type your name and press enter.
             string Name = Console.ReadLine();  // Create a string variable and get user input from the keyboard and store it in the variable.

             Console.WriteLine("Your name is: " + Name);  // Print the value of the variable (name), which will display the input value.
        }

        public void UserinputExample2()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); // Convert the input string(age is string) to an integer.

            Console.WriteLine("Your age is: " + age);  
        }

        // Second method using $ sign to print the value of the variable.
        public void UserinputExample3()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your age is: {age}");
        }
    }
}
