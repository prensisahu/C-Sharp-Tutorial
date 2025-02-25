using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class ConditionalStatements
    {
        public void ifStatment()
        {
            // Example 1
            if (10 > 8)
            {
                Console.WriteLine("10 is greater than 8");
            }

            // Example 2
            int a = 20;
            int b = 10;
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }

            // Example 3
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Congratlation you are eligible to vote!");
                }
            }
        }

        public void elseStatment()
        {
            {
                // Example 1
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("You are eligible to vote!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible to vote yet.");
                }
            }

            // Example 2

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
        }

        public void elseIfStatment()
        {
            // Example 1
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            // Example 2
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible to vote!");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("You are eligible to vote in some countries!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible to vote yet.");
                }
            }
        }
    }
}
